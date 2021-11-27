using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrail : MonoBehaviour {

    public TrailRenderer trail;

    public void turnOn()
    {
        trail.emitting = true;
    }
    public void turnOff()
    {
        trail.emitting = false;
    }
}
