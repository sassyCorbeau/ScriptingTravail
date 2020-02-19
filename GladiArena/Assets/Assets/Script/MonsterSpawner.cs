using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    //Script à mettre sur un gameObject empty

    public Transform[] spawnPoints;
    //remplir avec le nombre de spawns (donc 4 normalement) et avec les gameObject de spawn
    public GameObject[] monsters;
    //remplir avec le nombre d'ennemis différents et les prefabs des ennemis
    int randomSpawnPoint;
    int randomMonster;
    public static bool spawnAllowed;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 1f);
    }
  
    void Update()
    {
        
    }

    void SpawnAMonster()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, monsters.Length);
            Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
