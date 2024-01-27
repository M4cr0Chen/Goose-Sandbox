using System;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Rigidbody2D body;
    private float horizontalInput;
    private float verticalInput;
    private float jumpingPower = 30f;
    private float PositiveSpeed;
    private float NegativeSpeed;
    public float friction = 5f; // Adjust the friction value as needed
    
    [SerializeField] public LayerMask PlayerLayer;
    [SerializeField] public LayerMask groundLayer; // Set this in the Unity Editor to include the ground layer
    public float groundCheckDistance = 0.1f; // Adjust the radius based on your player's size
    public Player1Movement Player1;
    
    
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }
    
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Update()
    {
        PositiveSpeed = 5;
        NegativeSpeed = -5;
        //body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        /*if (isGrounded) // Friction Movements
         {
             // Get input for movement
             float horizontalInput = Input.GetAxis("Horizontal");
             float verticalInput = Input.GetAxis("Vertical");

             // Check if movement keys are pressed
             bool isMoving = Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f;

             // Apply friction to slow down the player when keys are released
             if (!isMoving)
             {
                 Vector2 currentVelocity = body.velocity;
                 Vector2 frictionForce = -currentVelocity.normalized * friction;
                 body.AddForce(frictionForce);
             }

             // Move the player using the Rigidbody2D component
             body.velocity = new Vector2(horizontalInput, verticalInput) * speed;
         }
         else // Normal Movement
         {*/
        
        // Get input for movement
        horizontalInput = Input.GetAxisRaw("Horizontal1");
        verticalInput = Input.GetAxisRaw("Vertical1");
        
        
             if (Input.GetKey(KeyCode.LeftArrow))
             {
                 body.velocity = new Vector2(NegativeSpeed * speed, body.velocity.y);
             }
             /*if (Input.GetKeyUp(KeyCode.LeftArrow))
             {
                 body.velocity = new Vector2(body.velocity.x * 0.5f, body.velocity.y);
             }*/
         
             if (Input.GetKey(KeyCode.RightArrow))
             {
                 body.velocity = new Vector2(PositiveSpeed * speed, body.velocity.y);
             }
             /*if (Input.GetKeyUp(KeyCode.RightArrow))
             {
                 body.velocity = new Vector2(body.velocity.x * 0.5f, body.velocity.y);
             }*/
         
             if (Input.GetKey(KeyCode.UpArrow) & IsGrounded())
             {
                 body.velocity = new Vector2(body.velocity.x, jumpingPower);
             }
             
             /*if (Input.GetKeyUp(KeyCode.UpArrow) && body.velocity.y > 0f)
             {
                 body.velocity = new Vector2(body.velocity.x, body.velocity.y * 0.5f);
             }*/
         
             if (Input.GetKey(KeyCode.DownArrow))
             {
                 body.velocity = new Vector2(body.velocity.x, NegativeSpeed * speed);
             }

             /*if (Input.GetKeyDown(KeyCode.Space))
             {
                 body.velocity = new Vector2(body.velocity.x, speed);
             }*/

             if (IsGrounded())
             {
                 Debug.Log("Goose on ground");
             }
             //}

        /*
        // Left Mouse Clicked
        if (Input.GetMouseButton(0))
        {
            
        }
        // Right Mouse Clicked
        if (Input.GetMouseButton(1))
        {
            
        }*/
    }
    /*private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        if (IsGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, verticalInput * speed);
        }
    }*/
}
