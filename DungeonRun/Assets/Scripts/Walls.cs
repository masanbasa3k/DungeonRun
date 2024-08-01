using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public float speed;
    private MeshRenderer meshRenderer;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        speed = gameManager.gameSpeed;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = gameManager.gameSpeed;
        meshRenderer.material.mainTextureOffset += new Vector2(-1f, 0) * Time.deltaTime * speed/10;
    }
}
