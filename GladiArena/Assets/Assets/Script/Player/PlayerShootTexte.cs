using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerShootTexte : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;

    public GameObject shotUp;
    public GameObject shotDown;
    public GameObject shotLeft;
    public GameObject shotRight;
    public GameObject shotUpRight;
    public GameObject shotUpLeft;
    public GameObject shotDownRight;
    public GameObject shotDownLeft;
    public static float fireRate = 0.5f;

    private float nextFire;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotUpRight, transform.transform);
            return;

        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotUpLeft, transform.transform);
            return;

        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotDownRight, transform.transform);
            return;

        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotDownLeft, transform.transform);
            return;

        }
        if (Input.GetKey(KeyCode.UpArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotUp, transform.transform);
            
        }
        if (Input.GetKey(KeyCode.DownArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotDown, transform.transform);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotLeft, transform.transform);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shotRight, transform.transform);
        }
             
    }
  
}
