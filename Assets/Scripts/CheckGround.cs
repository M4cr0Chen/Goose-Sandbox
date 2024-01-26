using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public LayerMask groundLayer; // Set this in the Unity Editor to include the ground layer
    public float groundCheckRadius = 0.1f; // Adjust the radius based on your player's size

    public bool isGrounded;

    void Update()
    {
        // Check if the player is on the ground
        CheckOnGround();
        
        // You can use the 'isGrounded' variable in your game logic
        if (isGrounded)
        {
            // Player is on the ground, you can perform actions like jumping or resetting jumps here
        }
    }

    void CheckOnGround()
    {
        // Perform an overlap circle check to see if the player is on the ground
        isGrounded = Physics2D.OverlapCircle(transform.position, groundCheckRadius, groundLayer);
    }
}
