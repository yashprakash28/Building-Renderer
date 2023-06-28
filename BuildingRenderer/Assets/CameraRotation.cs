using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    //public float movementSpeed = 5f;
    ////Vector3 lastCursorPosition;
    ////Vector3 currCursorPosition;
    ////float rotationSpeed = 0.5f;
    ////bool isRotating = false;

    float rotSpeed = 2;

    //public float xSpeed = 2f;
    //public float ySpeed = 0.0f;
    //public float zSpeed = 0.0f;

    public float scrollSpeed = 50f; // Adjust this value to control the camera movement speed
    float xRotation;
    public Transform playerBody;

    void Update()
    {

        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        // Move the camera forward or backward based on scroll input
        transform.Translate(Vector3.forward * scrollInput * scrollSpeed);

        if (Input.GetMouseButton(0))// && fixedTouchField.TouchDist.x > 0.5f)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            playerBody.Rotate(Vector3.up, -rotX * scrollSpeed, Space.World);
            //playerBody.Rotate(Vector3.right, rotY * scrollSpeed, Space.Self);
        }
    }
}
