using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    inputManager inputManager;
    playerLocomotion playerLocomotion;

    void Awake()
    {
        inputManager = GetComponent<inputManager>();
        playerLocomotion = GetComponent<playerLocomotion>();
    }

    void Update()
    {
        inputManager.HandleAllInputs();
    }

    void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Player has been hit");
    }
}
