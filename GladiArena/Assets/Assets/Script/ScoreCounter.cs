using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{


    public static float currentScore = 0;
    public Text scoreText;
    public Text scoreLoser;

    // Use this for initialization
    void Start()
    {
        currentScore = 0;

    }

    private void Update()
    {
        if (currentScore == 100)
        {
            // Debug.Log("Le score as augmenté");
        }
        scoreText.text = "Score : " + currentScore;
        scoreLoser.text = "Score : " + currentScore;
    }

  /*  private void HandleScore()
    {

        scoreText.text = "Score : " + currentScore;
    } */


    

}