using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static int PlayerHealth = 0;
    public GameObject gameoverUI;
    public GameObject ui;
    public GameObject decimus;

    public Text highScore;
    public GameObject highScoreUI;

    public Text lifeText;

    public AudioClip death;

    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        PlayerHealth = 0;
        highScoreUI.SetActive(false);
        gameoverUI.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        lifeText.text = PlayerHealth.ToString();

        if (PlayerHealth <= -1)
        {
            
            ui.SetActive(false);
            gameoverUI.SetActive(true);
            if(GameManager.score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", GameManager.score);
                highScore.text = GameManager.score.ToString();
                highScoreUI.SetActive(true);
            }

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
