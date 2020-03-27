using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGang : MonoBehaviour
{
    private enum Weapons
    {
        USP,
        SPAS,
        GLOCK
    }

    private readonly Dictionary<Weapons, int> _Weapons = new Dictionary<Weapons, int>();
    private Weapons currentWeapon;

    private void Start()
    {
        _Weapons.Add(0, 7);
        //currentWeapon = Weapons.USP;
    }

    private void Update()
    {

        if (_Weapons.ContainsKey(currentWeapon))
        {
            if (Input.GetKeyDown("a"))
            {
                currentWeapon = Weapons.USP;
                Debug.Log("USP");

            }

            if (Input.GetKeyDown("s"))
            {
                currentWeapon = Weapons.SPAS;
                Debug.Log("SPAS");

            }

            if (Input.GetKeyDown("d"))
            {
                currentWeapon = Weapons.GLOCK;
                Debug.Log("GLOCK");

            }
        }
    
    
    
    }

}
