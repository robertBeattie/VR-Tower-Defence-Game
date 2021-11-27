using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject enemy;
    public float count;
    public float cooldown = 5;
    public int position;

    // Update is called once per frame
    void Update () {
        position = Random.Range(0, 4);
        Debug.Log(position);
        if (count > cooldown)
        {
            GameObject na = Instantiate(enemy, spawnPoints[position], spawnPoints[position].gameObject);
            na.GetComponent<PathToPlayer>().ActiveEnemy();
            count = 0;
        }else
        {
            count += Time.deltaTime;
        }
       
    }
}
