using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : PlayerState
{

    Player player;

    public MoveLeft(Player player)
    {
        this.player = player;
    }

    public void DownMovement()
    {
        //throw new System.NotImplementedException();
        player.currentState = player.down;
        player.transform.Translate(Vector3.back * 2 * Time.deltaTime);
    }

    public void LeftMovement()
    {
        //throw new System.NotImplementedException();
        player.currentState = player.left;
        player.transform.Translate(Vector3.left * 2 * Time.deltaTime);
    }

    public void RightMovement()
    {
        //throw new System.NotImplementedException();
        player.currentState = player.right;
        player.transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }

    public void UpMovement()
    {
        //throw new System.NotImplementedException();
        player.currentState = player.up;
        player.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
    }
}
