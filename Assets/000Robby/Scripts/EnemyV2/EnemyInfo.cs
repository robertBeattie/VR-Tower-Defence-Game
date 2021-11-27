using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyInfo : MonoBehaviour {

    public float health = 100;
    public float speed = 14;
    private float startSpeed;
    private float speedCooldown = 0;
    public float damage = 10;
    public float worth = 5;
    public GameObject onDeath;
    NavMeshAgent nav;
    public Transform player;
    public bool awake = true;
    private WaveManager waveManager;
	// Use this for initialization
	void Start () {
        startSpeed = speed;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        nav.speed = speed;
        waveManager = GameObject.FindGameObjectWithTag("WaveManager").GetComponent<WaveManager>();
    }
	
	// Update is called once per frame
	void Update () {
        nav.speed = speed;
        if (awake)
        {
            nav.enabled = true;
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
        }
        if (health <= 0)
        {
            waveManager.enemylost();
            GameObject effect = (GameObject)Instantiate(onDeath, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            DestroyImmediate(gameObject);
            return;
        }
        if(speedCooldown <= 0)
        {
            speed = startSpeed;
        }
        else
        {
            speedCooldown -= Time.deltaTime;
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
    public void Slow(float amount)
    {
        speed = startSpeed * amount;
        speedCooldown = 2;
    }

}
