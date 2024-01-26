using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private float PositiveSpeed;
    private float NegativeSpeed;
    public float friction = 5f; // Adjust the friction value as needed
    
    public LayerMask PlayerLayer;
    public LayerMask groundLayer; // Set this in the Unity Editor to include the ground layer
    public float groundCheckDistance = 0.1f; // Adjust the radius based on your player's size
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

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
             if (Input.GetKey(KeyCode.LeftArrow))
             {
                 body.velocity = new Vector2(speed * 2 * NegativeSpeed, body.velocity.y);
             }
         
             if (Input.GetKey(KeyCode.RightArrow))
             {
                 body.velocity = new Vector2(speed * 2 * PositiveSpeed, body.velocity.y);
             }
         
             if (Input.GetKey(KeyCode.UpArrow))
             {
                 body.velocity = new Vector2(body.velocity.x, speed * 1);
             }
         
             if (Input.GetKey(KeyCode.DownArrow))
             {
                 body.velocity = new Vector2(body.velocity.x, speed * -1);
             }

             if (Input.GetKey(KeyCode.Space))
             {
                 body.velocity = new Vector2(body.velocity.x, speed);
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
}
