using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioClip menu;
    bool playCheck = false;
    bool quitCheck = false;
    float playTimmer=0f;

    /* void update()
    {
        if(playcheck == true)
        {
            playTimmer = playTimmer + Time.deltatime;
            if (playTimmer >= 2.1)
            {
                SceneManager.LoadScene(1);
                playTimmer = 0;
            }
        }
        if (quitCheck == true)
        {
            playTimmer = playTimmer + Time.deltatime;
            if (playTimmer >= 2.1)
            {
                Application.Quit();
            }
        }
    }*/
    public void PlayGame()
    {
        //playCheck = true;
        AudioSource camSource = Camera.main.GetComponent<AudioSource>();
        Debug.Log("Tu dum !(du menu)");
        camSource.clip = menu;
        camSource.Play();
        /*
        if (camSource.isPlaying()) 
        {; }*/
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        //quitCheck = true;

        AudioSource camSource = Camera.main.GetComponent<AudioSource>();
        Debug.Log("Tu dum !(du menu)");
        camSource.clip = menu;
        camSource.Play();
        
        
    }
}
