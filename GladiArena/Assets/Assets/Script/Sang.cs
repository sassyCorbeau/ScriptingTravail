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

<<<<<<< HEAD
<<<<<<< HEAD

<<<<<<< HEAD
=======
    public void OnDestroy()
    {

        Instantiate(tacheDeSang, transform.position, transform.rotation);
<<<<<<< HEAD

=======
>>>>>>> 71d8660e45d5eeeee7fb8293a69b4fa26aa939c5
>>>>>>> 0b1d92fe36794e15b74bae28b48c335ca9abc617
>>>>>>> d1ed988c3ab1cb8814fddcfd959bed74c0158007
>>>>>>> 0e61607e7ce81e8db5e2b3de91b73f5facca41dc
=======
=======
>>>>>>> 8054a28379bcaa35125daa1dc8b1d62fbfca4ac9
>>>>>>> ab71601b54a569d422b9c61079ac3909a0f70e14
    }
    
}


