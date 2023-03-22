using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker : MonoBehaviour
{
    public DrawLines drawLines;

    private Command drawBlue;
    private Command drawRed;

    public Stack<Command> commandHistory;

    private int colorNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        drawBlue = new DrawBlue(drawLines);
        drawRed = new DrawRed(drawLines);
        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if(colorNum == 1)
        {
            drawBlue.Execute();
            commandHistory.Push(drawBlue);
        }

        if(colorNum == 2)
        {
            drawRed.Execute();
            commandHistory.Push(drawRed);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            colorNum = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorNum = 2;
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (commandHistory.Count != 0)
            {
                //pop the last command off our stack
                Command lastCommand = commandHistory.Pop();

                //call Undo() on the last command
                lastCommand.Undo();

                lastCommand.DestroyLastObject();
            }
        }
    }
}
