using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteractions : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // finding the player with the tag named player
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When the obstacle touches a object with a border tag it will destroy
        if(collision.tag == ("Border"))
        {
            // Destroying the gameobject when touching the border
            Destroy(this.gameObject);
        }

        // When the obstacle touches a object with a player tag it will destroy
        else if(collision.tag == "Player")
        {
            // Destroying the gameobject when touching the player
            Destroy(player.gameObject);
        }

    }

        
}
