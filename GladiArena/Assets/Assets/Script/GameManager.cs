﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PowerUP =0;

    bool fireRate = false;
    bool spreasShot = false;
    bool speedBoost = false;
    bool shield = false;
    bool multiHit = false;
    bool defaut = false;
    // Start is called before the first frame update
    void Start()
    {
        //PowerUP = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PowerUPSwitch();

    }

    void PowerUPSwitch()
    {
        switch (PowerUP)
        {
            case 0:
                if (Input.GetKeyDown("space"))
                {

                    Debug.Log("hey");
                }
                break;
            case 1:
                if (Input.GetKeyDown("space"))
                {
                    fireRate = true;
                    PowerUP = 0;
                    Debug.Log("ca marche");
                }
                    break;
            case 2:
                if (Input.GetKeyDown("space"))
                {
                    spreasShot = true;
                    PowerUP = 0;
                }
                break;
            case 3:
                if (Input.GetKeyDown("space"))
                {
                    speedBoost = true;
                    PowerUP = 0;
                }
                break;
            case 4:
                if (Input.GetKeyDown("space"))
                {
                    shield = true;
                    PowerUP = 0;
                }
                break;
            case 5:
                if (Input.GetKeyDown("space"))
                {
                    multiHit = true;
                    PowerUP = 0;
                }
                break;
             default:

                if (Input.GetKeyDown("space"))
                {
                    defaut = true;
                    PowerUP = 0;
                }
                break;
        }
    }
 
}
