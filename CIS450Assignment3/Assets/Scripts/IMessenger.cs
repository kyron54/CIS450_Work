using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMessenger 
{
    public void RegisterObservers() { }

    public void RemoveObservers() { }

    public void NotifyObservers() { }
}
