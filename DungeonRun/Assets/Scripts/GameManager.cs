using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int live;
    public TMP_Text liveText;
    public int score;
    public int speedScore;
    public TMP_Text scoreText;
    public GameObject spikePrefab;
    public GameObject coinPrefab;
    public GameObject torchPrefab;


    public int gameSpeed = 1;

    void Start()
    {
        live = 3;
        score = 0;
        StartCoroutine(SpawnSpike());
        StartCoroutine(SpawnCoin());
        StartCoroutine(SpawnTorch());
    }

    void Update()
    {
        liveText.text = "Live: " + live;
        
        scoreText.text = "Score: " + score;
        
        // if score is divisible by 10, increase the game speed
        if (speedScore % 1000 == 0 && speedScore != 0)
        {
            gameSpeed++;
            speedScore = 0;
        }
    }

    IEnumerator SpawnSpike()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f/gameSpeed, 15f/gameSpeed));
            Instantiate(spikePrefab, new Vector3(Random.Range(-3f, 3f), 0, 40), Quaternion.identity);
        }
    }

    IEnumerator SpawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f/gameSpeed, 20f/gameSpeed));
            Instantiate(coinPrefab, new Vector3(Random.Range(-3f, 3f), 1, 40), Quaternion.identity);
        }
    }

    IEnumerator SpawnTorch()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f/gameSpeed, 20f/gameSpeed));
            if (Random.Range(0, 2) == 0)
            {
                Instantiate(torchPrefab, new Vector3(4.5f, 2.5f, 40), Quaternion.identity);
            }
            else
            {
                Instantiate(torchPrefab, new Vector3(-4.5f, 2.5f, 40), Quaternion.identity);
            }
        }
    }

    
}
