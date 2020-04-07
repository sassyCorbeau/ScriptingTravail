using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour
{
    public AudioClip collect;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LifeUP(other);
        }
    }

    public void LifeUP(Collider player)
    {
        Debug.Log("Life Up");
        PlayerHP.PlayerHealth++;
        Debug.Log(PlayerHP.PlayerHealth);
        Destroy(gameObject);
    }

    void OnDestroy()
    {

        AudioSource camSource = Camera.main.GetComponent<AudioSource>();
        Debug.Log("Tu dum !");
        camSource.clip = collect;
        camSource.Play();

    }

    

}
