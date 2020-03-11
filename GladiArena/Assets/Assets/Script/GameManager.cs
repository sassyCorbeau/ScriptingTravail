using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int PowerUP = 0;


    public GameObject pUp1;
    public GameObject pUp2;
    public GameObject pUp3;
    public GameObject pUp4;
    public GameObject pUp5;



    static public float timerPower = 0;




    bool fireRate = false;
    bool spreadShot = false;
    bool speedBoost = false;
    bool shield = false;
    static public bool multiHit = false;
    bool defaut = false;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = false;
        spreadShot = false;
        speedBoost = false;
        shield = false;
        multiHit = false;
        defaut = false;
        PowerUP = 0;

        //PowerUP = 0;

        pUp1.GetComponent<Image>().color = Color.grey;
        pUp2.GetComponent<Image>().color = Color.grey;
        pUp3.GetComponent<Image>().color = Color.grey;
        pUp4.GetComponent<Image>().color = Color.grey;
        pUp5.GetComponent<Image>().color = Color.grey;


    }

    // Update is called once per frame
    void Update()
    {

        PowerUPSwitch();

        fireRatePower();

        shieldPower();

        speedBoostPower();




    }

    void PowerUPSwitch()
    {
        switch (PowerUP)
        {
            case 0:
                if (Input.GetKeyDown("space"))
                {

                    Debug.Log("hey");


                    Debug.Log("=0");

                }
                break;
            case 1:
                pUp1.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    fireRate = true;
                    PowerUP = 0;

                    pUp1.GetComponent<Image>().color = Color.grey;
                    Debug.Log("ca marche");

                    Debug.Log("fireRate");


                }
                break;
            case 2:
                pUp1.GetComponent<Image>().color = Color.grey;
                pUp2.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    spreadShot = true;
                    PowerUP = 0;

                    pUp2.GetComponent<Image>().color = Color.grey;

                    Debug.Log("spreadshot");

                }
                break;
            case 3:
                pUp2.GetComponent<Image>().color = Color.grey;
                pUp3.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    speedBoost = true;
                    PowerUP = 0;

                    pUp3.GetComponent<Image>().color = Color.grey;

                    Debug.Log("speadboost");

                }
                break;
            case 4:
                pUp3.GetComponent<Image>().color = Color.grey;
                pUp4.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    shield = true;
                    PowerUP = 0;

                    pUp4.GetComponent<Image>().color = Color.grey;

                    Debug.Log("shield");

                }
                break;
            case 5:
                pUp4.GetComponent<Image>().color = Color.grey;
                pUp5.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    multiHit = true;
                    PowerUP = 0;

                    pUp5.GetComponent<Image>().color = Color.grey;

                    Debug.Log("multy");

                }
                break;
            default:

                if (Input.GetKeyDown("space"))
                {
                    defaut = true;
                    PowerUP = 0;
                    pUp5.GetComponent<Image>().color = Color.grey;
                }
                break;
        }

    }
    void fireRatePower()
    {

        if (fireRate == true)
        {
            pUp1.GetComponent<Image>().color = Color.blue;
            Debug.Log("fireRate = True");

            timerPower = timerPower + Time.deltaTime;

            PlayerShootTexte.fireRate = 0.2f;
            Debug.Log("Firerate changée");
            if (timerPower > 10)
            {
                fireRate = false;
                Debug.Log("fireRate End");
                PlayerShootTexte.fireRate = 0.5f;
                pUp1.GetComponent<Image>().color = Color.grey;
                timerPower = 0;
                return;
            }


        }
    }

    void shieldPower()
    {
        if (shield == true)
        {
            pUp4.GetComponent<Image>().color = Color.blue;
            Debug.Log("Shield is on");

            timerPower = timerPower + Time.deltaTime;
            PlayerHP.PlayerHealth = 2;

            if (PlayerHP.PlayerHealth == 1)
            {
                Debug.Log("Shield is off");
                timerPower = 0;
                shield = false;
                return;
            }

            if (timerPower > 10)
            {
                Debug.Log("Shield is off");
                PlayerHP.PlayerHealth = 1;
                shield = false;
                pUp4.GetComponent<Image>().color = Color.grey;
                timerPower = 0;
                return;
            }



            


        }
    }
    void speedBoostPower()
    {
        if (speedBoost == true)
        {
            pUp3.GetComponent<Image>().color = Color.blue;
            Debug.Log("speedBoost = True");

            timerPower = timerPower + Time.deltaTime;

            PlayerMvt.speed = 18f;
            Debug.Log("speedBoost changée");
            if (timerPower > 10)
            {
                speedBoost = false;
                pUp3.GetComponent<Image>().color = Color.grey;
                Debug.Log("speedBoost End");
                PlayerMvt.speed = 6f;
                timerPower = 0;
                return;
            }



        }
    }
}


