using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Update is called once per frame
    public GameManager gameManager;
    public int moveSpeed;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        moveSpeed = gameManager.gameSpeed;
    }
    void Update()
    {
        // Move the spike down
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);

        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }

}
