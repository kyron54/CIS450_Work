using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MoveBehavior
{
    float speed = 5;

    public override void MovementType()
    {
        //base.MovementType();

        float x = Input.GetAxis("Horizontal") * speed;

        x *= Time.deltaTime;

        transform.Translate(x, 0, 0);

        Debug.Log("Use A and D to move Left and right. Press 1 or 2 to change the movement type.");

    }
}
