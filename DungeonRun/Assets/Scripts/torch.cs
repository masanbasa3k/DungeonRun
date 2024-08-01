using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{
    // Update is called once per frame
    public GameManager gameManager;
    public int moveSpeed;


    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        moveSpeed = gameManager.gameSpeed;
        // check the rotation of the torch
        if (transform.position.x > 0)
        {
            transform.Rotate(0, 180, 0);
        }
    }
    void Update()
    {
        // Coin'i aşağı doğru hareket ettir
        moveSpeed = gameManager.gameSpeed;
        transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);

        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
