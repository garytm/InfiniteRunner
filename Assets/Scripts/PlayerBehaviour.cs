using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float movementSpeed = 0.1f;
    public float jumpHeight = 0.1f;
    public bool grounded;
    //accessing the layers within Unity for collision checks
    public LayerMask ground;
    //accessing the players rigid body in code
    private Rigidbody2D playerRigidBody;
    private Collider2D playerCollider;
    private Animator playerAnimator;

	void Start ()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerAnimator = GetComponent<Animator>();
	}

	void Update ()
    {
        Movement();
	}

    void Movement()
    {
        //checking if the player is colliding with the ground layer mask and setting grounded to true
        grounded = Physics2D.IsTouchingLayers(playerCollider, ground);
        //making the player run without stopping and jump when the jump key is pressed
        playerRigidBody.velocity = new Vector2(movementSpeed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
            }
        }
        //setting the animator variables to change based on the players speed and grounded variables
        playerAnimator.SetFloat("Speed", playerRigidBody.velocity.x);
        playerAnimator.SetBool("Grounded", grounded);
    }
}
