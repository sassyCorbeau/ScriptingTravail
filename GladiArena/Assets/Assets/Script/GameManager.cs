using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PowerUP ;
    // Start is called before the first frame update
    void Start()
    {
        PowerUP = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUP == 1)
        {
            Debug.Log("Power up is nik twa!");
        }
    }
}
