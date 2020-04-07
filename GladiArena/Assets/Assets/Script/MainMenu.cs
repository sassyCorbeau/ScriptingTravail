using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource selectionAudioClip;

    bool ReadyToLoad = false;

    void Update()
    {
        if (ReadyToLoad == true && !selectionAudioClip.isPlaying)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void StartGame()
    {
        selectionAudioClip.Play(0);
        ReadyToLoad = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
