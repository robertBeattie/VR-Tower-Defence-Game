using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour {
    public GameObject explotionPrefab;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("BOOM!");
            Transform pos = collision.gameObject.transform;
            Damage(collision.gameObject.transform);
        }
    }

    void Damage(Transform enemy)
    {
        EnemyInfo e = enemy.GetComponent<EnemyInfo>();

        if (e != null)
        {
            e.TakeDamage(1000000);
        }
    }
}
