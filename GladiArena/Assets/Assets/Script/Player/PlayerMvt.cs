using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMvt : MonoBehaviour
{
    public static float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController Cc;
    public GameObject fin;
    public Animator animator;

    Vector2 movement;

    void Start()
    {
        Cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        Cc.velocity.Set(0, 0, 0);

        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveDirection *= speed;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

           /* if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }  */
            // Peut être utilisé pour tirer
        

          //  moveDirection.y -= gravity * Time.deltaTime;
         // Désactivé a cause du mot gravity, ça fait peur
       Cc.Move(moveDirection * Time.deltaTime);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);



    }
    
}
