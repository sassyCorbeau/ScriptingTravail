using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sang : MonoBehaviour
{
    public GameObject tacheDeSang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnDestroy()
    {
<<<<<<< HEAD

=======
        Instantiate(tacheDeSang, transform.position, transform.rotation);
>>>>>>> 71d8660e45d5eeeee7fb8293a69b4fa26aa939c5
    }
}


