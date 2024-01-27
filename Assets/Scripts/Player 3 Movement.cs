using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Player3Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the move speed as needed
    public float friction = 5f; // Adjust the friction value as needed
    private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;

    // IsGrounded Variables
    public LayerMask groundLayer; // Set this in the Unity Editor to include the ground layer
    public float groundCheckDistance = 0.1f; // Adjust the distance based on your player's size
    public bool Grounded;
    
    private void OnCollisionEnter2D (Collision2D Collision)
    {
        if (Collision.gameObject.name == "Ground")
        {
            Debug.Log("Collided To Ground");
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input for movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        /*
        if (!Grounded) // If is grounded, user input invalid
        {
            horizontalInput = 0;
            verticalInput = 0;

        } else // else user input are read
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }*/
        // Call the function to move the player using AddForce
        MovePlayer(horizontalInput, verticalInput);
        if (Grounded)
        {
            ApplyFriction();
        }
        
    }

    void MovePlayer(float horizontal, float vertical)
    {
        // Calculate the movement vector
        Vector2 movement = new Vector2(horizontal, vertical);

        // Normalize the vector to avoid faster movement diagonally
        movement.Normalize();

        // Add force to the Rigidbody to move the player
        rb.AddForce(movement * moveSpeed);
    }

    void ApplyFriction()
    {
        // Calculate the friction force
        Vector2 frictionForce = -rb.velocity.normalized * friction;

        // Apply the friction force to the Rigidbody
        rb.AddForce(frictionForce);
    }
}
