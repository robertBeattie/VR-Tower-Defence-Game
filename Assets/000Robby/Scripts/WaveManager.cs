using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyList;
    public GameObject[] Enemys; //Normal
    public int enemysLeft = 0;
    public int waveNumber = 0;
    int spawnCounter = 0;
    int enemyCounter = 0;
    // Use this for initialization
    void Start()
    {
        enemysLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            restart();
        }
        if (enemysLeft == 0)
        {
            NextWave();
            enemyCounter = 0;
        }
        if(enemyCounter < enemyList.Length)
        {
            GameObject na = Instantiate(enemyList[enemyCounter], spawnPoints[spawnCounter].transform);
            na.GetComponent<EnemyInfo>().awake = true;
            enemyCounter++;
            spawnCounter++;
            //Invoke("SummonEnemy", 2f);
        }
        if (spawnCounter >= spawnPoints.Length)
        {
            spawnCounter = 0;
        }
    }
    void NextWave()
    {
        waveNumber++;
        enemysLeft = 3 * waveNumber;
        enemyList = new GameObject[3 * waveNumber];
        int fromList = 0;
        for (int i = 0; i < enemyList.Length; i++)
        {
            if(fromList >= Enemys.Length) { fromList = 0; }
            enemyList[i] = Enemys[fromList];
            fromList++;
        }
        
    }
    void SummonEnemy()
    {
        GameObject na = Instantiate(enemyList[enemyCounter], spawnPoints[spawnCounter].transform);
        na.GetComponent<EnemyInfo>().awake = true;
        enemyCounter++;
        spawnCounter++;
    }
    public void enemylost()
    {
        enemysLeft -= 1;
    }
    private void restart()
    {
        waveNumber = 0;
    }
}
