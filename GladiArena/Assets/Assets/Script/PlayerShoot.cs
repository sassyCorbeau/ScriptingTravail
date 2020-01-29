using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletUp;
    public GameObject bulletDown;
    public GameObject bulletLeft;
    public GameObject bulletRight;
    public GameObject bulletUpRight;
    public GameObject gunSfx;
    public float nextFire;
    public float fireRate = 1f;
    void Start()
    {
        InvokeRepeating("ShootUp", 2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
                {
                nextFire = Time.time + fireRate;
                Instantiate(bulletUpRight, transform.transform);
                    return;
                }
            ShootUp();
            
            

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Destroy(Instantiate(gunsfx, transform.position, transform.rotation), 0.5f);
            // Destroy(Instantiate(gunSfx, transform.position, transform.rotation), 2f);
            Instantiate(bulletDown, transform.transform);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Destroy(Instantiate(gunsfx, transform.position, transform.rotation), 0.5f);
            // Destroy(Instantiate(gunSfx, transform.position, transform.rotation), 2f);
            Instantiate(bulletLeft, transform.transform);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Destroy(Instantiate(gunsfx, transform.position, transform.rotation), 0.5f);
           // Destroy(Instantiate(gunSfx, transform.position, transform.rotation), 2f);
            Instantiate(bulletRight, transform.transform);

        }
        
        
    }
    void ShootUp()
    {
        // Destroy(Instantiate(gunsfx, transform.position, transform.rotation), 0.5f);
        // Destroy(Instantiate(gunSfx, transform.position, transform.rotation), 2f);
        Instantiate(bulletUp, transform.transform);
        return;
    }
}
