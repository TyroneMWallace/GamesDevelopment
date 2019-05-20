//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //reference to the player, speciaffaly the transform componant
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        //refers to position of camera, set to players position every frame
        //without offset, grants a POV view, with it we can set an X, Y and Z value for the cameras position
        transform.position = player.position + offset;
    }
}
