using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PrintBehavior : MonoBehaviour
{
    public string startLine;

    public abstract void PrintStartLine(string _startLine);
}
