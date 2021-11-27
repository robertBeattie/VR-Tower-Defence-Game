using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour {
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    public float cooldown = 2.5f;

    public float cooldownO = 2;
    public float cooldownGP = 2;
    // Use this for initialization
    void Start () {
        orange.SetActive(false);
        green.SetActive(false);
        purple.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (cooldownO <= 0)
        {
            orange.SetActive(false);

        }
        if (cooldownGP <= 0)
        {
            green.SetActive(false);
            purple.SetActive(false);
        }
        //update cooldowns
        cooldownO -= Time.deltaTime;
        cooldownGP -= Time.deltaTime;
        if (Input.GetKeyDown("z")) toggleOrange();
        if (Input.GetKeyDown("x")) toggleGreen();
        if (Input.GetKeyDown("c")) togglePurple();

    }
    public void toggleOrange()
    {
        if (cooldownO <= 0)
        {
            orange.SetActive(true);
            cooldownO = cooldown;
        }
    }
    public void toggleGreen()
    {
        if (cooldownGP <= 0)
        {
            green.SetActive(true);
            cooldownGP = cooldown;
        }
    }
    public void togglePurple()
    {
        if (cooldownGP <= 0)
        {
            purple.SetActive(true);
            cooldownGP = cooldown;
        }
    }
}
