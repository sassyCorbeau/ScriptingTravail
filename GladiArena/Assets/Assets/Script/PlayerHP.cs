﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int PlayerHealth;
    public GameObject gameoverUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth == 0)
        {
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