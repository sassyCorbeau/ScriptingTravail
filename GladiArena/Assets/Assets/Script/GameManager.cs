using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int PowerUP = 0;

    

    public GameObject pUp1;
    public GameObject pUp1Activable;
    public GameObject pUp1Active;
    public GameObject pUp2;
    public GameObject pUp2Activable;
    public GameObject pUp2Active;
    public GameObject pUp3;
    public GameObject pUp3Activable;
    public GameObject pUp3Active;
    public GameObject pUp4;
    public GameObject pUp4Activable;
    public GameObject pUp4Active;
    public GameObject pUp5;
    public GameObject pUp5Activable;
    public GameObject pUp5Active;

    public GameObject goShield;

    public GameObject scoreDisplay;
    public GameObject scoreGO;

    static public float timerPower = 0;

    public static int tempScoreUp = 0;
    public static int score = 0;

    bool fireRate = false;
    static public bool spreadShot = false;
    bool speedBoost = false;
    public static bool shield = false;
    static public bool multiHit = false;
    bool defaut = false;

    public static bool playergethit = false;

    public GameObject shieldsprite;

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
        score = 0;

        goShield.SetActive(false);
        

        //PowerUP = 0;

    }

    // Update is called once per frame
    void Update()
    {

        PowerUPSwitch();

        fireRatePower();

        shieldPower();

        speedBoostPower();

        multiHitActive();

        spreadShotActive();

        scoreDisplay.GetComponent<Text>().text = score.ToString();
        scoreGO.GetComponent<Text>().text = score.ToString();
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
                pUp1Activable.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    fireRate = true;
                    PowerUP = 0;

                    pUp1Activable.SetActive(false);
                    Debug.Log("ca marche");

                    Debug.Log("fireRate");


                }
                break;
            case 2:
                pUp1Activable.SetActive(false);
                pUp2Activable.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    spreadShot = true;
                    PowerUP = 0;

                    pUp2Activable.SetActive(false);

                    Debug.Log("spreadshot");

                }
                break;
            case 3:
                pUp2Activable.SetActive(false);
                pUp3Activable.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    speedBoost = true;
                    PowerUP = 0;

                    pUp3Activable.SetActive(false);

                    Debug.Log("speadboost");

                }
                break;
            case 4:
                pUp3Activable.SetActive(false);
                pUp4Activable.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    shield = true;
                    PowerUP = 0;

                    pUp4Activable.SetActive(false);
                   

                    Debug.Log("shield");

                }
                break;
            case 5:
                pUp4Activable.SetActive(false);
                pUp5Activable.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    multiHit = true;
                    PowerUP = 0;

                    pUp5Activable.SetActive(false);

                    Debug.Log("multy");

                }
                break;
            default:
                if (Input.GetKeyDown("space"))
                {
                    defaut = true;
                    multiHit = true;
                    PowerUP = 0;
                    pUp5Activable.SetActive(false);
                    score += tempScoreUp;
                    tempScoreUp = 0;
                }
                break;
        }

    }
    void fireRatePower()
    {

        if (fireRate == true)
        {
            pUp1Active.SetActive(true);
            

            timerPower = timerPower + Time.deltaTime;

            PlayerShootTexte.fireRate = 0.2f;
            
            if (timerPower > 10)
            {
                fireRate = false;
                
                PlayerShootTexte.fireRate = 0.5f;
                pUp1Active.SetActive(false);
                timerPower = 0;
                return;
            }


        }
    }

    void shieldPower()
    {

        if (shield == true)
        {
            goShield.SetActive(true);

            pUp4Active.SetActive(true);
            //shieldsprite.SetActive(true);
            
        }
        else
        {
            
            pUp4Active.SetActive(false);

        }
    }
    

    void speedBoostPower()
    {
        if (speedBoost == true)
        {
            pUp3Active.SetActive(true);
            
            timerPower = timerPower + Time.deltaTime;

            PlayerMvt.speed = 12f;
            
            if (timerPower > 10)
            {
                speedBoost = false;
                pUp3Active.SetActive(false);
                
                PlayerMvt.speed = 6f;
                timerPower = 0;
                return;
            }



        }
    }
    void multiHitActive()
    {
        if (PlayerShootTexte.multiHitActive == true)
        {
            pUp5Active.SetActive(true);
        }

        if (timerPower > 9.9)
        {
            pUp5Active.SetActive(false);
        }
    }
    void spreadShotActive()
    {
        if (PlayerShootTexte.spreadShotActive == true)
        {
            pUp2Active.SetActive(true);
        }

        if (timerPower > 9.9)
        {
            pUp2Active.SetActive(false);
        }
    }
}


