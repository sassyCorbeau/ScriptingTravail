using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
   public enum SpawnState { SPAWNING, WAITING, COUNTING };

    public AudioClip newWave;

    [System.Serializable]
   public class Wave
    {
        //remplir avec un ennemi au hasard c'est pas important
        public Transform enemy;

        //remplir avec nombre d'ennemis de la première vague
        public int count;

        //remplir avec 1 ou 2 tkt ça passe
        public float rate;
    }



    public Wave waves;
    private int nextWave = 0;

    //remplir avec 12 en size (3 par côté) pour forcer le joueur à se déplacer
    public Transform[] spawnPoints;

    //remplir avec les types d'ennemis et leurs prefabs
    public GameObject[] enemies;

    //à changer au besoin
    public float timeBetweenWaves = 5f;
    public float waveCountdown;
    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;

    private void Start()
    {


        if(spawnPoints.Length == 0)
        {
            Debug.LogError("You Suck");
        }

        waveCountdown = timeBetweenWaves;
    }

    private void Update()
    {
        if(state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                
                WaveEnd();
            }
            else
            {
                return;
            }
        }

        


        if(waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine ( SpawnWave ( waves ) );
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveEnd()
    {
        Debug.Log("Wave End");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
       
        nextWave = -1;

        AudioSource camSource = Camera.main.GetComponent<AudioSource>();
        Debug.Log("Tu Waves !");
        camSource.clip = newWave;
        camSource.Play();

        //à changer au besoin
        waves.count += 2;
    }

    

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("bad") == null)
            {
                return false;
            }            
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave");
        state = SpawnState.SPAWNING;

        for(int i =0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {

            Debug.Log("Spawning Enemy: " + _enemy.name);
            Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject _monsters = enemies[Random.Range(0, enemies.Length)];
            Instantiate(_monsters, _sp.position, _sp.rotation);

    }
}
