using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    Transform transform;
    public float speed = 20f;
	// Use this for initialization
	void Start () {
        transform = this.gameObject.transform;

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(this.transform.position, speed * Time.deltaTime);
	}
}
