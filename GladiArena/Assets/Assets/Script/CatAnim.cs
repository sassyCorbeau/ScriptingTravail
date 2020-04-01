using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnim : MonoBehaviour
{
    public Animator animator;

    Vector2 movement;
    public Vector3 oldposition;
    public float move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deplacement = transform.position - oldposition;
        Debug.Log("Creation déplacement");
        // movement.x = Input.GetAxisRaw("Horizontal");
        // movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", deplacement.x * 250);
        Debug.Log("SetHrz");
        Debug.Log(deplacement.x);
        // animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", deplacement.sqrMagnitude * 250);
        Debug.Log("Setspeed");
        Debug.Log(deplacement.sqrMagnitude);

        oldposition = transform.position;
        Debug.Log("Setold");
    }
}
