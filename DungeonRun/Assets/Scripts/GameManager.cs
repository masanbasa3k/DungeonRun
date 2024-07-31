using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int live;
    public TMP_Text liveText;
    public int score;
    public TMP_Text scoreText;
    public GameObject spikePrefab;
    public GameObject coinPrefab;


    public int gameSpeed = 1;

    void Start()
    {
        live = 3;
        score = 0;
        StartCoroutine(SpawnSpike());
    }

    void Update()
    {
        liveText.text = "Live: " + live;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnSpike()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 2f));
            Instantiate(spikePrefab, new Vector3(Random.Range(-3f, 3f), 0, 20), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Instantiate(coinPrefab, new Vector3(Random.Range(-3f, 3f), 1, 20), Quaternion.identity);
        }
    }

    
}
