using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
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
        // Coin'i aşağı doğru hareket ettir
        transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);

        // Coin'i Y ekseni etrafında döndür
        transform.Rotate(0, 200 * Time.deltaTime, 0);
        

        // Coin z pozisyonu -10'dan küçük olduğunda nesneyi yok et
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
