using UnityEngine;

//Blah Blah Blah
public class Player1Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private float PositiveSpeed;
    private float NegativeSpeed;

    private float playerX;
    
    public LayerMask PlayerLayer;
    public LayerMask groundLayer; // Set this in the Unity Editor to include the ground layer
    
    
    private void Collided()
    {
        
    }
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);

        // Access the X and Y coordinates
        float playerX = playerPosition.x;
        float playerY = playerPosition.y;

        if (playerX >= 100)
        {
            Debug.Log("Next level entered");
        }
        
        
        PositiveSpeed = 5;
        NegativeSpeed = -5;
        
        // body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        
        if (Input.GetKey(KeyCode.A))
        {
            body.velocity = new Vector2(speed * NegativeSpeed, body.velocity.y);
        }
         
        if (Input.GetKey(KeyCode.D))
        {
            body.velocity = new Vector2(speed * PositiveSpeed, body.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            body.velocity = new Vector2(body.velocity.x, speed * PositiveSpeed);
        }
         
        if (Input.GetKey(KeyCode.S))
        {
            body.velocity = new Vector2(body.velocity.x, speed * NegativeSpeed);
        }

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);
    }
}
