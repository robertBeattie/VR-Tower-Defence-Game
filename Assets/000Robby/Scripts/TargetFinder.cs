using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFinder : MonoBehaviour {
    public Transform target;
    public PlayerBullet playerBullet;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
                target = other.gameObject.transform;
                playerBullet.startTracking();
                playerBullet.target = target;
                return;
        }
    }
}
