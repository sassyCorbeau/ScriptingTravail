using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUpRight : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    void Start()
    {
        transform.parent = null;
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        GetComponent<Rigidbody>().velocity = new Vector3(40f, 40f, 0f);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("stop"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("bad"))
        {
            Destroy(gameObject);
        }
    }
}
