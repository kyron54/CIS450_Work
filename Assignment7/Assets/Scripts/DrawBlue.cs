using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBlue : Command
{
    DrawLines drawLines;
    Stack<GameObject> lineHistory;

    Color lineColor = new Color(0, 0, 255);

    public DrawBlue(DrawLines drawLines)
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
        if(lineHistory.Count != 0)
        {
            lineHistory.Pop();
        }
    }

    public void DestroyLastObject()
    {
        GameObject.Destroy(drawLines.GetLastLine());
    }
}
