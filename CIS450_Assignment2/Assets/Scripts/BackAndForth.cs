using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MoveBehavior
{

    float speed = 5;

    public override void MovementType()
    {
        //base.MovementType();

        float z = Input.GetAxis("Vertical") * speed;

        z *= Time.deltaTime;

        transform.Translate(0, 0, z);

        Debug.Log("Use W and S to move forwards and backwards. Press 1 or 2 to change the movement type.");

    }
}
