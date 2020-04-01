using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sang : MonoBehaviour
{
    public GameObject tacheDeSang;
    public GameObject tacheDeSang2;
    private float sangLaiiser;

    //   mettre sur l 'ennemie

    public void OnDestroy()
    {
        sangLaiiser = (Random.Range(0, 2));

        if (sangLaiiser == 0)
        {
            Debug.Log("Trainner 1");
            Instantiate(tacheDeSang, transform.position, transform.rotation);

            return;
        }
        if (sangLaiiser == 1)
        {
            Instantiate(tacheDeSang2, transform.position, transform.rotation);
            Debug.Log("Trainner 2");

            return;
        }
        if (sangLaiiser == 2)
        {

            Debug.Log("Rien");
            return;
        }
<<<<<<< HEAD
=======

>>>>>>> ab71601b54a569d422b9c61079ac3909a0f70e14
    }
    
}


