using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REPLAY : MonoBehaviour
{
   public void ReSatan()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void PasReSatan()
    {
        SceneManager.LoadScene(0);
       
    }
}
