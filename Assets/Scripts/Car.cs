using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle 
{
    // POLYMORPHISM
    protected override void PlayerControl()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            base.speed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            base.speed /= 2;
        }
        base.PlayerControl();
    }
}
