using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInHere : MonoBehaviour {
    public GameObject[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public int firstWait = 2;
    public float SpawnRangeMin = 2;
    public float SpawnRangeMax = 5;
    private int spawnCounter = 0;
    private int enemyCounter = 0;
    // Use this for initialization
    void Start () {
        //spawnCounter = spawnPoints.Length;
        //spawnPoints[spawnCounter] = this.gameObject;
        Invoke("SummonEnemy", firstWait);
	}
	
	
    void SummonEnemy()
    {
        GameObject na = Instantiate(enemyPrefabs[enemyCounter], spawnPoints[spawnCounter].transform);
        na.GetComponent<EnemyInfo>().awake = true;
        Invoke("SummonEnemy", Random.Range(SpawnRangeMin, SpawnRangeMax));
        spawnCounter++;
        enemyCounter++;
        if (spawnCounter >= spawnPoints.Length)
        {
            spawnCounter = 0;
        }
        if (enemyCounter >= enemyPrefabs.Length)
        {
            enemyCounter = 0;
        }
    }
}
