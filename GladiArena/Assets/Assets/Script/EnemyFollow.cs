using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed = 5f;
    //Changer sur l'inspector si la vitesse ne va pas
    public AudioClip enemyKill;
    

    public Transform Player;
    //Remplir sur l'inspector avec le Player



    private int timerMort = 0;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
        
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Player.position, transform.position) > 1.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }

        

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            GameManager.score += 50;
            Destroy(gameObject);

            AudioSource camSource = Camera.main.GetComponent<AudioSource>();
            Debug.Log("Tu creves ! ;')");
            camSource.clip = enemyKill;
            camSource.Play();
        }
    }


}

