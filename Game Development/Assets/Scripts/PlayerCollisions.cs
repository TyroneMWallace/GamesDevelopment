//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement movement;

   
    //Called when object collides with something
    void OnCollisionEnter( Collision collisionInfo)
    {
        //all obstacles with the tag obstacles interact with this
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // When in collision with obstacle, player stops
            FindObjectOfType<GameManager>().EndGame();



        }
    }
}