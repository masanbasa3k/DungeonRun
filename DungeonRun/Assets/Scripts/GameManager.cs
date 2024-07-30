using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int live;
    public int score;
    public GameObject spikePrefab;
    public int gameSpeed = 1;

    void Start()
    {
        live = 3;
        score = 0;
        StartCoroutine(SpawnSpike());
    }

    IEnumerator SpawnSpike()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(spikePrefab, new Vector3(Random.Range(-6f, 6f), 1.5f, 20), Quaternion.identity);
        }
    }
}
