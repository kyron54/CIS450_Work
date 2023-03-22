using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRed : Command
{
    DrawLines drawLines;
    Stack<GameObject> lineHistory;

    Color lineColor = new Color(255, 0, 0);

    public DrawRed(DrawLines drawLines)
    {
        this.drawLines = drawLines;
        lineHistory = new Stack<GameObject>();
    }

    public void Execute()
    {
        drawLines.DrawLine(lineColor);

        lineHistory.Push(drawLines.GetLastLine());
    }

    public void Undo()
    {
        if (lineHistory.Count != 0)
        {
            lineHistory.Pop();
        }
    }

    public void DestroyLastObject()
    {
        GameObject.Destroy(lineHistory.Peek());
    }
}
