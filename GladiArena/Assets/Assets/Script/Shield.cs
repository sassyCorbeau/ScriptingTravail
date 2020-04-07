using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

     void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("bad"))
        {
            GameManager.shield = false;

            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            
        }
    }
}
