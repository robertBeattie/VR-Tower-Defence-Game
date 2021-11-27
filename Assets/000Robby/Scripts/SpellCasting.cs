using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class SpellCasting : MonoBehaviour {
    public GameObject fireball;
    public GameObject lfireball;
    // public Vector3 location;
    public Transform position;
    //HandModel hand_model;
    //Hand hand;


    void Start()
    {
        //hand_model = GetComponent<HandModel>();
        //hand = hand_model.GetLeapHand();
    }
    void Update()
    {
        //location = new Vector3(hand.PalmPosition.x, hand.PalmPosition.y, hand.PalmPosition.z);
        //position.position = location;

        if (Input.GetKey("k"))
        {
            summonFire(position);
        }

    }
    public void summonFire(Transform hand)
    {
        Debug.Log("Activated");
        GameObject ng = Instantiate(fireball, hand.position, hand.rotation);
        ng.GetComponent<Transform>().Rotate(new Vector3(0, 0, -40f));
        ng.GetComponent<Rigidbody>().velocity = ng.transform.right * ng.GetComponent<PlayerBullet>().speed;
        Destroy(ng, 6f);
    }
    public void summonLeftFire(Transform hand)
    {
        Debug.Log("Activated");
        GameObject ng = Instantiate(lfireball, hand.position, hand.rotation);
        ng.GetComponent<Transform>().Rotate(new Vector3(0, 0, -40f));
        ng.GetComponent<Rigidbody>().velocity = ng.transform.right * -1 * ng.GetComponent<PlayerBullet>().speed;
        Destroy(ng, 6f);
    }

}
