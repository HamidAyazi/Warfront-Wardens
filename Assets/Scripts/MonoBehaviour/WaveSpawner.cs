using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float waveInterval = 5f;

    private Vector3 SpawnPointPosition;
    private float countdown = 1f;
    private int waveNumber = 0;
    private bool waveToggle = false;

    
    [SerializeField] private Sprite playImage;
    [SerializeField] private Sprite pauseImage;

    private void Update(){
        if(waveToggle){
            if (countdown <= 0) {
                StartCoroutine(SpawnWave());
                countdown = waveInterval;
            }
            countdown -= Time.deltaTime;
        }
    }

    private IEnumerator SpawnWave(){
        waveNumber++;
        float enemyCount = waveNumber;
        GameStats.Wave = waveNumber;
        for (int i = 0; i < (int)enemyCount; i++) {
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
        }
    } 

    private void SpawnEnemy(){
        Instantiate(enemyPrefab, SpawnPointPosition, Quaternion.identity);
    }

    /// <summary>
    /// Start or Stop an Enemy Wave.
    /// </summary>
    public void ToggleWave()
    {
        SpawnPointPosition = SaveManager.Instance.Data.map.SpawnPointPosition;
        waveToggle = !waveToggle;
    }

}

