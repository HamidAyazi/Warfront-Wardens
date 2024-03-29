using UnityEngine;
using UnityEngine.UI;
using NavMeshPlus.Components;
using static GameData;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs; // Prefabs for different tile types

    private Map mapData; // Your Map data
    private int tileSize = 1; // Size of each tile
    public NavMeshSurface Surface2D;

    // loading screen
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider slider;
    // loading screen


    private void Awake()
    {
        mapData = SaveManager.Instance.FindMap(LoadingScreen.MapId);
        SaveManager.Instance.Data.map = mapData;
    }
    private void Start()
    {
        GenerateMap();
    }

    private void GenerateMap()
    {
        Vector3 spawnPosition = Vector3.zero;
        Vector3 cameraCenter = Camera.main.transform.position;
        GameObject NewTile;
        GameObject tilePrefab;
        int tileIndex;
        int tileType;

        // Calculate the starting position for the map based on the camera's position and the map's size
        float mapWidth = (mapData.XSize * tileSize) - 2;
        float mapHeight = (mapData.TileMap.Length / mapData.XSize) * tileSize;
        Vector3 mapStartPosition = cameraCenter - new Vector3(mapWidth / 2f, -mapHeight / 2f, 0f);
        spawnPosition.z = 0;

        for (int y = 0; y < mapData.TileMap.Length / mapData.XSize; y++)
        {
            for (int x = 0; x < mapData.XSize; x++)
            {
                tileIndex = x + y * mapData.XSize;
                tileType = mapData.TileMap[tileIndex];
                tilePrefab = tilePrefabs[tileType];

                if (tilePrefab != null)
                {
                    spawnPosition.x = mapStartPosition.x + x * tileSize;
                    spawnPosition.y = mapStartPosition.y - y * tileSize;

                    NewTile = Instantiate(tilePrefab, spawnPosition, Quaternion.identity);
                    if(tileType == 1)
                    {   
                        NewTile = Instantiate(tilePrefabs[3], spawnPosition, Quaternion.identity);
                        SaveManager.Instance.Data.map.SpawnPointPosition = NewTile.transform.position;
                    }
                    if(tileType == 2)
                    {   
                        SaveManager.Instance.Data.map.GoalPointPosition = NewTile.transform.position;
                    }
                }
            }
            float result = (float)y / ((float)mapData.TileMap.Length / (float)mapData.XSize); // update loading screen slider
            slider.value = (result / 2f + 0.5f); // update loading screen slider
        }
        loadingScreen.SetActive(false); // disable loading screen
        Surface2D.BuildNavMeshAsync();
    }
}
