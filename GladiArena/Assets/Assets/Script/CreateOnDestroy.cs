using System.Collections.Generic;
using UnityEngine;
using System.Collections;




public class CreateOnDestroy : MonoBehaviour
{
    public GameObject lifePickup;
    public GameObject powerUp;
    private float itemChoose;

    // Script a mettre sur l'ennemi, qui renvoi si oui ou non un powerUp est laché.

    
    public void OnDestroy()
    {
      

        itemChoose = (Random.Range(0, 10));

        if (itemChoose == 0)
        {
            Debug.Log("Objet 0");
            Instantiate(lifePickup, transform.position, transform.rotation);
            return;
        }
        if (itemChoose == 1)
        {
            Debug.Log("Objet 1");
            return;
        }
        if (itemChoose == 2)
        {
            Debug.Log("Objet 2");
            Instantiate(powerUp, transform.position, transform.rotation);
            return;
        }
        if (itemChoose == 3)
        {
            Debug.Log("Objet 3");
            return;
        }
        if (itemChoose == 4)
        {
            Debug.Log("Objet 4");
            return;
        }
        if (itemChoose == 5)
        {
            Debug.Log("Objet 5");
            return;
        }
        if (itemChoose == 6)
        {
            Debug.Log("Objet 6");
            Instantiate(powerUp, transform.position, transform.rotation);
            return;
        }
        if (itemChoose == 7)
        {
            Debug.Log("Objet 7");
            return;
        }
        if (itemChoose == 8)
        {
            Debug.Log("Objet 8");
            return;
        }
        if (itemChoose == 9)
        {
            Debug.Log("Objet 9");
            return;
        }

        
    }
}

