using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public static int PlayerHealth = 1;
    public GameObject gameoverUI;
    public GameObject ui;
    public GameObject decimus;

    public AudioClip death;
   

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth == 0)
        {
            // ui.SetActive(false);
            gameoverUI.SetActive(true);
            Destroy(decimus);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("bad"))
        {
            Destroy (collision.gameObject);

            if(GameManager.shield == true)
            {
                GameManager.playergethit = true;
                return;
            }

                AudioSource camSource = Camera.main.GetComponent<AudioSource>();
                Debug.Log("Tu mort !");
                camSource.clip = death;
                camSource.Play();

            Debug.Log("PlayerHP--");
            PlayerHealth--;
        }
    }


}
