using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sang : MonoBehaviour
{
    public GameObject tacheDeSang;
    public GameObject tacheDeSang2;
    private float sangLaiiser;
    public float timeToWait = 5f;

    //   mettre sur l 'ennemie

    public void OnDestroy()
    {
        sangLaiiser = (Random.Range(0, 2));

        if (sangLaiiser == 0)
        {
            Debug.Log("Trainner 1");
            Destroy(Instantiate(tacheDeSang, transform.position, transform.rotation), timeToWait);

            return;
        }
        if (sangLaiiser == 1)
        {
            Destroy(Instantiate(tacheDeSang2, transform.position, transform.rotation), timeToWait);
            Debug.Log("Trainner 2");

            return;
        }
        if (sangLaiiser == 2)
        {

            Debug.Log("Rien");
            return;
        }

    }
    
}


