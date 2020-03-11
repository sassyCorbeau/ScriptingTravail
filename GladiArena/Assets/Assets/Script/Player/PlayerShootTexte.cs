﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]


public class PlayerShootTexte : MonoBehaviour
{


    public GameObject shotUp; // Les différents tirs
    public GameObject shotDown;
    public GameObject shotLeft;
    public GameObject shotRight;
    public GameObject shotUpRight;
    public GameObject shotUpLeft;
    public GameObject shotDownRight;
    public GameObject shotDownLeft;
    public static float fireRate = 0.5f; // La cadence 
    public static bool multiHitActive = false; // De quoi ajouter la gestion du hud qui se trouve dans le gamemanager
    public static bool spreadShotActive = false; // De quoi ajouter la gestion du hud qui se trouve dans le gamemanager
    public GameObject spreadShotUp; // Les différents tirs du spreadshot
    public GameObject spreadShotDown;
    public GameObject spreadShotLeft;
    public GameObject spreadShotRight;

    private float nextFire; // La variable pour la cadence

    void Update()
    {   
        // Spreadshot

        if (GameManager.spreadShot == true)
        {
            Debug.Log("SpreadShot = True");
            spreadShotActive = true;


            GameManager.timerPower = GameManager.timerPower + Time.deltaTime;

            if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(spreadShotUp, transform.transform);

            }
            if (Input.GetKey(KeyCode.DownArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(spreadShotDown, transform.transform);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(spreadShotLeft, transform.transform);
            }
            if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(spreadShotRight, transform.transform);
            }

            if (GameManager.timerPower > 10)
            {
                GameManager.spreadShot = false;
                Debug.Log("SpreadShot End");

                spreadShotActive = false;


                PlayerShootTexte.fireRate = 0.5f;
                GameManager.timerPower = 0;
                return;
            }
        }

        // MultiHit

        if (GameManager.multiHit == true)
        {
<<<<<<< HEAD
           
=======
>>>>>>> daa9ea4af439c0818d927aa98eba619887fca49b
            Debug.Log("Multihit = True");
            multiHitActive = true;


            GameManager.timerPower = GameManager.timerPower + Time.deltaTime;

            Debug.Log("Multihit changée");
            if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire || (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire || (Input.GetKey(KeyCode.DownArrow) && Time.time > nextFire || (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire))))
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotUp, transform.transform);
                Instantiate(shotRight, transform.transform);
                Instantiate(shotLeft, transform.transform);
                Instantiate(shotDown, transform.transform);
                Instantiate(shotDownLeft, transform.transform);
                Instantiate(shotDownRight, transform.transform);
                Instantiate(shotUpLeft, transform.transform);
                Instantiate(shotUpRight, transform.transform);
                
            }
            if (GameManager.timerPower > 10)
            {
                GameManager.multiHit = false;
                Debug.Log("Multihit End");

                multiHitActive = false;

<<<<<<< HEAD
                
=======
<<<<<<< HEAD
=======
                GameManager.pUp5.GetComponent<Image>().color = Color.grey;
>>>>>>> 2accffcda5de4c25f651b8b236e19bc5a367d614
>>>>>>> daa9ea4af439c0818d927aa98eba619887fca49b

                PlayerShootTexte.fireRate = 0.5f;
                GameManager.timerPower = 0;
                return;
            }
        }

        // Shot

        if (GameManager.multiHit == false)
        {
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotUpRight, transform.transform);
                return;

            }
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotUpLeft, transform.transform);
                return;

            }
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotDownRight, transform.transform);
                return;

            }
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotDownLeft, transform.transform);
                return;

            }
            if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotUp, transform.transform);

            }
            if (Input.GetKey(KeyCode.DownArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotDown, transform.transform);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotLeft, transform.transform);
            }
            if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shotRight, transform.transform);
            }

            
        }

        

        

    }
}



