 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public FixedJoystick Joystick;
    public float moveSpeed = 2f;
    public Rigidbody2D rb;
    public Animator animator;
    
    Vector2 movement;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }
    void Update()
    {
        //input
        movement.x = Joystick.Horizontal;
        movement.y = Joystick.Vertical;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    void OnFire()
    {
        animator.SetTrigger("swordAttack");
    }
}
