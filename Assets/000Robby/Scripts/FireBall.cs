using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = transform.forward * 6;
        Destroy(this.gameObject, 5);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
