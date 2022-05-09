using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // This variable will dictate how fast our player will be moving
    public float playerSpeed;
    // Variable to use Rigigidbody to use physics
    public Rigidbody2D rb;
    // This variable will be used to process our player's input
    private Vector2 playerDirections;

    // Start is called before the first frame update
    void start()
    {   
        // Fetching the RigidBody2D froming our player game object
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //  To detect which key the user is pressing
        float directionY = Input.GetAxisRaw("Vertical");
        // TO make the players movemnet Consistent
        playerDirections = new Vector2(0, directionY). normalized;
    }
    
    // Called once per physics frame
    void FixedUpdate()
    {
        // Speed of the rigidbody
        rb.velocity = new Vector2(0, playerDirections.y * playerSpeed);
    
   
     }
 }
    