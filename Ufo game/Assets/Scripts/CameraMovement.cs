using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // This variable will dicatate how fast the camera will be moving
    public float cameraSpeed;


    // Update is called once per frame
    void Update()
    {
        // Continuously changing the x posistion of the camera
       transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
