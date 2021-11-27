using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMoved : MonoBehaviour {

    Vector3 current;
    Vector3 start;
	// Use this for initialization
	void Start () {
        start = this.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        current = this.transform.position;
        if (start != current)
        {
            this.GetComponent<Rigidbody>().useGravity = true;
        }
	}
}
