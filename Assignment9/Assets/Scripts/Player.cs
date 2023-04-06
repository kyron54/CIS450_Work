using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerState up { get; set; }
    public PlayerState down { get; set; }
    public PlayerState right { get; set; }
    public PlayerState left { get; set; }
    public PlayerState currentState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        up = new MoveUp(this);
        down = new MoveDown(this);
        right = new MoveRight(this);
        left = new MoveLeft(this);

        currentState = up;
    }

    public void MoveRight() { currentState.RightMovement(); }
    public void MoveLeft() { currentState.LeftMovement();  }
    public void MoveUp() { currentState.UpMovement(); }
    public void MoveDown() { currentState.DownMovement(); }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Current enemy state: " + currentState);
        }

        if(Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.S))
        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }

    }
}
