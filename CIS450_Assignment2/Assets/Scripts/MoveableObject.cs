using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveableObject : MonoBehaviour
{

    #region Fields

    public MoveBehavior moveBehavior;
    PrintBehavior printBehavior;

    #endregion

    #region Functions

    public void SetMovetype()
    {
        // Activates Back and Forth Movement
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(GetComponent<MoveBehavior>());
            moveBehavior = gameObject.AddComponent<BackAndForth>();
        }

        // Activates Side to Side Movement
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(GetComponent<MoveBehavior>());
            moveBehavior = gameObject.AddComponent<SideToSide>();
        }
    }

    public void Move()
    {
        moveBehavior.MovementType();
    }
    #endregion
}
