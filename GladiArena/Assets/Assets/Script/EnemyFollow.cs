using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed = 5f;
    //Changer sur l'inspector si la vitesse ne va pas

    public Transform Player;
    //Remplir sur l'inspector avec le Player
    private int timerMort = 0;

    void Start()
    {

    }

    void Update()
    {
        
        
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Player.position, transform.position) > 1.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }

        else
        {
            /*
             variable de vie -1
             destroy all enemies
             variable de power-up = 0

            à remplir après dans le script du GameManager un if(variable de vie = 0) --> ouvrir scene de game over
            */
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
    }
}

