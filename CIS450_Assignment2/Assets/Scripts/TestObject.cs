using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MoveableObject
{
    // Start is called before the first frame update
    private void Start()
    {
        moveBehavior = gameObject.AddComponent<SideToSide>();
    }

    // Update is called once per frame
    void Update()
    {

        SetMovetype();

        Move();

    }

}
