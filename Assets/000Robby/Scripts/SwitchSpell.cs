using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSpell : MonoBehaviour {
    public SpellCasting spellCasting;
    public GameObject ice;
    public GameObject fire;
    public GameObject thunder;

    public Material blue;
    public Material red;
    private void Start()
    {
        red.color = Color.red;
        blue.color = Color.blue;
    }

    public void switchFire()
    {
        if(spellCasting.fireball == fire)
        {
            spellCasting.fireball = ice;
            red.color = Color.blue;
        } else if(spellCasting.fireball == ice)
        {
            spellCasting.fireball = thunder;
            red.color = Color.magenta;
        }
        else if (spellCasting.fireball == thunder)
        {
            spellCasting.fireball = fire;
            red.color = Color.red;
        }

    }
    public void switchIce()
    {
        if (spellCasting.lfireball == fire)
        {
            spellCasting.lfireball = ice;
            blue.color = Color.blue;
        }
        else if (spellCasting.lfireball == ice)
        {
            spellCasting.lfireball = thunder;
            blue.color = Color.magenta;
        }
        else if (spellCasting.lfireball == thunder)
        {
            spellCasting.lfireball = fire;
            blue.color = Color.red;
        }
    }
}
