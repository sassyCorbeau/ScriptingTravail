using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour
{
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

  
}
