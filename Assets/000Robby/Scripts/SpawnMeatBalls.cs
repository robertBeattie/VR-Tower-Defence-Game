using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnMeatBalls : MonoBehaviour {

    public GameObject[] meatBall;
    public Transform spawnlocation;
	public bool stop = true;
	
	// Update is called once per frame
	void Update () {
        Random rnd = new Random();
        
        int dice = Random.Range(0, 7);
        if (!stop) {
            Instantiate(meatBall[dice], spawnlocation);
        }
            
	}
}
