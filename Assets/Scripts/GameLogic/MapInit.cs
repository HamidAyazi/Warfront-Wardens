using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapInit
{
    public static List<GameData.Map> GetDefaultMaps()
    {
        List<GameData.Map> MapsToLoad = new List<GameData.Map>();
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 1,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 2, 0, 3, 3, 3, 0, 0,
                0, 0, 0, 3, 4, 3, 4, 3, 0, 0,
                0, 0, 0, 3, 4, 1, 4, 3, 4, 0,
                0, 0, 0, 3, 4, 0, 4, 3, 4, 0,
                0, 4, 0, 3, 3, 3, 0, 3, 0, 0,
                0, 4, 0, 0, 0, 3, 4, 3, 0, 0,
                0, 0, 4, 0, 0, 3, 3, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 4, 4, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 2,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 4, 3, 3, 3, 4, 0,
                0, 0, 0, 0, 0, 0, 4, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 4, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 4, 3, 0, 0,
                0, 0, 3, 3, 3, 3, 3, 3, 0, 0,
                0, 0, 3, 4, 0, 4, 0, 4, 0, 0,
                0, 0, 3, 3, 3, 3, 0, 0, 0, 0,
                0, 0, 0, 0, 4, 2, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 3,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 4, 4, 4, 0, 0, 
                0, 0, 0, 3, 3, 3, 3, 3, 3, 0, 
                0, 0, 4, 3, 4, 0, 4, 4, 3, 4,
                0, 2, 3, 3, 0, 0, 0, 4, 3, 4, 
                0, 0, 4, 0, 0, 0, 3, 3, 3, 0, 
                4, 0, 0, 0, 0, 4, 3, 4, 0, 0, 
                0, 4, 4, 0, 1, 3, 3, 0, 0, 4, 
                0, 0, 0, 0, 0, 0, 0, 0, 4, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 4,
            XSize = 11,
            TileMap = new int[]
            {
                0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0,
                0, 0, 3, 3, 3, 2, 0, 4, 4, 0, 0,
                0, 4, 3, 0, 0, 0, 0, 0, 4, 0, 0,
                0, 4, 3, 0, 0, 0, 4, 4, 0, 4, 0,
                4, 0, 3, 0, 0, 1, 3, 3, 3, 0, 4,
                0, 4, 3, 0, 0, 4, 0, 0, 3, 4, 0,
                0, 4, 3, 0, 0, 0, 0, 0, 3, 4, 0,
                0, 0, 3, 3, 3, 3, 3, 3, 3, 0, 0,
                0, 0, 0, 4, 4, 0, 4, 4, 0, 0, 0,
                0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 5,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 4, 0,
                4, 0, 0, 0, 0, 4, 4, 0, 0, 0,
                4, 0, 0, 2, 3, 3, 3, 4, 0, 0,
                0, 4, 0, 0, 4, 0, 3, 0, 0, 0,
                0, 3, 3, 3, 3, 4, 3, 0, 0, 0,
                0, 3, 0, 4, 3, 0, 3, 4, 0, 0,
                0, 3, 4, 1, 3, 4, 3, 4, 0, 0,
                0, 3, 4, 4, 0, 4, 3, 0, 0, 0,
                4, 3, 3, 3, 3, 3, 3, 0, 0, 0,
                0, 0, 0, 4, 4, 0, 0, 4, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 6,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 3, 0, 0, 0, 0,
                1, 4, 0, 0, 0, 3, 3, 3, 3, 0,
                3, 0, 4, 4, 0, 3, 4, 4, 3, 0,
                3, 4, 3, 4, 0, 3, 4, 3, 3, 0,
                3, 3, 3, 4, 4, 3, 0, 3, 0, 0,
                4, 4, 3, 3, 3, 3, 4, 3, 0, 0,
                0, 0, 3, 4, 4, 0, 4, 3, 0, 0,
                0, 4, 4, 4, 0, 4, 4, 3, 0, 0,
                2, 3, 3, 3, 3, 3, 3, 3, 0, 0,
                0, 4, 4, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 7,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 2, 0, 0, 0, 1, 0, 0,
                0, 0, 4, 3, 0, 0, 0, 3, 0, 0,
                0, 3, 3, 3, 0, 0, 4, 3, 0, 0,
                0, 3, 4, 4, 0, 0, 4, 3, 0, 0,
                0, 3, 3, 3, 4, 0, 0, 3, 4, 0,
                0, 0, 4, 3, 4, 4, 0, 3, 4, 0,
                0, 0, 4, 3, 3, 3, 4, 3, 4, 0,
                0, 0, 0, 0, 4, 3, 4, 3, 0, 0,
                0, 0, 0, 0, 0, 3, 3, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 8,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 3, 2, 0, 1, 3, 0, 0, 0,
                0, 4, 3, 4, 4, 4, 3, 4, 0, 0,
                3, 3, 3, 0, 0, 0, 3, 3, 3, 0,
                3, 4, 0, 0, 0, 4, 0, 4, 3, 0,
                3, 4, 0, 0, 4, 0, 0, 4, 3, 0,
                3, 4, 0, 4, 0, 0, 0, 4, 3, 0,
                3, 3, 3, 0, 0, 0, 3, 3, 3, 0,
                0, 4, 3, 4, 4, 4, 3, 4, 0, 0,
                0, 0, 3, 3, 3, 3, 3, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 9,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 2, 0, 4, 3, 3, 3, 0, 0,
                0, 3, 3, 4, 3, 3, 4, 3, 4, 0,
                0, 3, 4, 4, 3, 4, 4, 3, 0, 0,
                0, 3, 3, 4, 3, 4, 3, 3, 0, 0,
                0, 4, 3, 3, 3, 4, 1, 4, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 10,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 3, 3, 3, 1, 0,
                0, 0, 4, 0, 0, 3, 4, 0, 0, 0,
                0, 0, 0, 0, 4, 3, 3, 3, 3, 0,
                0, 4, 4, 4, 4, 4, 4, 4, 3, 0,
                3, 3, 3, 3, 3, 3, 3, 3, 3, 0,
                3, 4, 4, 4, 4, 4, 4, 4, 0, 0,
                3, 3, 3, 3, 4, 0, 0, 0, 0, 0,
                0, 0, 4, 3, 0, 0, 4, 0, 0, 0,
                2, 3, 3, 3, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 11,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 4, 3, 3, 3, 3, 3, 2, 0, 0,
                0, 3, 3, 4, 4, 4, 0, 0, 0, 0,
                0, 3, 4, 4, 3, 3, 3, 3, 0, 0,
                0, 3, 4, 3, 3, 4, 4, 3, 0, 0,
                0, 3, 4, 3, 4, 4, 3, 3, 0, 0,
                0, 3, 0, 3, 4, 3, 3, 4, 0, 0,
                0, 3, 3, 3, 0, 1, 4, 4, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 12,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 3, 3, 3, 3, 0, 2, 3, 3,
                0, 0, 3, 4, 4, 3, 0, 0, 4, 3,
                0, 0, 3, 4, 4, 3, 0, 0, 4, 3,
                0, 0, 3, 4, 4, 3, 0, 4, 4, 3,
                3, 3, 3, 4, 3, 3, 0, 3, 3, 3,
                3, 4, 4, 0, 3, 4, 4, 3, 0, 0,
                3, 4, 0, 0, 3, 4, 4, 3, 0, 0,
                3, 3, 1, 0, 3, 3, 3, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 13,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                3, 3, 3, 3, 3, 3, 3, 0, 0, 0,
                3, 4, 4, 4, 4, 0, 3, 4, 0, 0,
                3, 3, 3, 3, 3, 4, 3, 0, 4, 0,
                0, 4, 0, 4, 3, 4, 3, 3, 3, 0,
                4, 3, 3, 3, 3, 0, 4, 4, 3, 0,
                4, 3, 0, 4, 0, 0, 0, 0, 3, 4,
                4, 3, 3, 3, 3, 4, 0, 4, 3, 0,
                0, 4, 4, 0, 1, 0, 4, 3, 3, 3,
                0, 0, 0, 0, 0, 0, 0, 2, 4, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 14,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 3, 3, 3, 3, 3, 0, 0,
                1, 0, 0, 3, 4, 0, 4, 3, 0, 0,
                3, 3, 4, 3, 0, 4, 3, 3, 0, 0,
                4, 3, 4, 3, 4, 0, 3, 4, 0, 0,
                3, 3, 0, 3, 0, 4, 3, 0, 0, 0,
                3, 4, 4, 3, 4, 0, 3, 0, 0, 0,
                3, 3, 3, 3, 0, 4, 3, 0, 0, 0,
                0, 4, 4, 0, 4, 0, 3, 0, 0, 0,
                2, 3, 3, 3, 3, 3, 3, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 15,
            XSize = 10,
            TileMap = new int[]
            {
                0, 0, 4, 0, 0, 0, 0, 4, 4, 0,
                0, 4, 4, 4, 0, 0, 0, 0, 4, 4,
                0, 0, 4, 0, 0, 0, 4, 3, 0, 0,
                4, 0, 0, 0, 0, 3, 3, 3, 3, 0,
                0, 0, 0, 0, 0, 3, 3, 4, 3, 0,
                3, 3, 3, 3, 0, 3, 4, 4, 3, 0,
                0, 0, 3, 0, 0, 2, 0, 0, 3, 4,
                0, 0, 3, 4, 4, 4, 0, 4, 3, 4,
                0, 0, 1, 3, 3, 3, 3, 3, 3, 0,
                0, 0, 0, 4, 4, 0, 0, 0, 0, 0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });
        MapsToLoad.Add(new GameData.Map()
        {
            MapID = 16,
            XSize = 11,
            TileMap = new int[]
            {
                0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0,
                0, 0, 4, 3, 3, 0, 3, 4, 0, 0, 0,
                0, 0, 3, 3, 0, 3, 3, 4, 4, 0, 0,
                0, 3, 3, 0, 3, 3, 4, 3, 3, 3, 0,
                4, 3, 0, 1, 3, 4, 3, 3, 0, 3, 4,
                0, 3, 3, 0, 4, 3, 3, 0, 3, 3, 0,
                0, 0, 3, 3, 0, 2, 0, 3, 3, 0, 0,
                0, 0, 4, 3, 3, 0, 3, 3, 4, 0, 0,
                0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 4, 0, 0, 0, 0 ,0
            },
            Waves = new Wave[]
            {
                new Wave
                {
                    EnemyID = 1,
                    EnemyNumber = 5,
                    EnemyLevel = 1,
                    TimeToSpawn = 5f,
                },
                new Wave
                {
                    EnemyID = 2,
                    EnemyNumber = 10,
                    EnemyLevel = 2,
                    TimeToSpawn = 5f,
                }
            }
        });


        return MapsToLoad;
    }

}
