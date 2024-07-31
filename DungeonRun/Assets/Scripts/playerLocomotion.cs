using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLocomotion : MonoBehaviour
{
    inputManager inputManager;
    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody playerRigidbody;

    public float movementSpeed = 7;
    public float rotationSpeed = 15;

    private void Awake()
    {
        inputManager = GetComponent<inputManager>();
        playerRigidbody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }
    // public void HandleAllMovement()
    // {
    //     HandleMovement();
    // }
    // private void HandleMovement()
    // {
    //     moveDirection = cameraObject.forward * inputManager.verticalInput;
    //     moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
    //     moveDirection.Normalize();
    //     moveDirection.y = 0;
    //     moveDirection = moveDirection * movementSpeed;

    //     Vector3 movementVelocity = moveDirection;
    //     playerRigidbody.velocity = movementVelocity;
    // }
}
