using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtCtuluAnim : MonoBehaviour
{
    public Animator animator;

    Vector2 movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
