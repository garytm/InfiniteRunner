using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float movementSpeed = 0.1f;
    public float jumpHeight = 0.1f;
    private float jumpDelay = 1.0f;

    private Rigidbody2D playerRigidBody; 

	void Start ()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
	}

	void Update ()
    {
        jumpDelay += Time.deltaTime;
        Movement();
	}

    void Movement()
    {
        playerRigidBody.velocity = new Vector2(movementSpeed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && jumpDelay > 1.0f)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
            jumpDelay = 0.0f;
        }
    }
}
