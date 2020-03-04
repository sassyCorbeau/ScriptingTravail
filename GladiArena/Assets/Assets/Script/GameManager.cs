using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int PowerUP =0;

    public GameObject pUp1;
    public GameObject pUp2;
    public GameObject pUp3;
    public GameObject pUp4;
    public GameObject pUp5;

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
                pUp1.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    fireRate = true;
                    PowerUP = 0;
                    pUp1.GetComponent<Image>().color = Color.grey;
                    Debug.Log("ca marche");
                }
                    break;
            case 2:
                pUp1.GetComponent<Image>().color = Color.grey;
                pUp2.GetComponent<Image>().color = Color.red;
                if (Input.GetKeyDown("space"))
                {
                    spreasShot = true;
                    PowerUP = 0;
                    pUp2.GetComponent<Image>().color = Color.grey;
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
}
