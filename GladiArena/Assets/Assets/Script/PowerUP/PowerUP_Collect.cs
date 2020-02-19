﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP_Collect : MonoBehaviour

{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    // La fonction nommé Pickup :
    public void Pickup(Collider player)
    {
        Debug.Log("Power up is picked !");
        GameObject.Find("GameManger").GetComponent<GameManager>().PowerUP++;
        Destroy(gameObject);
    }
}