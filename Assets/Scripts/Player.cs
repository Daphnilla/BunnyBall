using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public byte speed = 2; //automatically 2 but can be changed
    public Rigidbody rb;
    public Transform cameraTransform;
    public GameManager gameManager;

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        //Read input from the user
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Moves the characters on scene
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Vector3 direction = forward * moveVertical + right * moveHorizontal;
        rb.AddForce(direction * speed); //replace with speed variable
    }
}
