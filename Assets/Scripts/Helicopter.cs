using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : Vehicle
{
    // POLYMORPHISM
    protected override void PlayerControl()
    {
        base.PlayerControl();
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftControl) && transform.position.y > 0.1f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
