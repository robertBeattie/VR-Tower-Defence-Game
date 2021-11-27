using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathToPlayer : MonoBehaviour {
    public Transform player;
    NavMeshAgent nav;
    public bool active = false;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();        
    }
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            nav.SetDestination(player.position);
            active = true;
        }
    }
    public void ActiveEnemy()
    {
        nav.enabled = true;
        active = true;
    }
}
