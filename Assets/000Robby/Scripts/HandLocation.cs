using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class HandLocation : MonoBehaviour {
    public Vector position;
    Vector velocity;
    public Vector direction;
    Controller controller = new Controller();
    Frame frame;

     void Start()
    {
        frame = controller.Frame(); // controller is a Controller object
    }
    // Update is called once per frame
    void Update () {


        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;
            Hand firstHand = hands[0];

            Vector position = hands[0].PalmPosition;
            Vector velocity = hands[0].PalmVelocity;
            Vector direction = hands[0].Direction;
        }
  
       
    }
}
