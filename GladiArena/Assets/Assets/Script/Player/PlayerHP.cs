using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public static int PlayerHealth = 1;
    public GameObject gameoverUI;
    public GameObject ui;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth == 0)
        {
            ui.SetActive(false);
            gameoverUI.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bad"))
        {
            Debug.Log("PlayerHP--");
            PlayerHealth--;
        }
    }
}
