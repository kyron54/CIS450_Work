using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEffector : MonoBehaviour , IMessenger
{
    List<IReceiver> observers = new List<IReceiver>();

    public float maxScale;
    public float currentScale;
    public int colorNum;

    public void RegisterObservers(IReceiver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObservers(IReceiver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        foreach(IReceiver observer in observers)
        {
            observer.UpdateData(currentScale, maxScale, colorNum);
        }
    }

    void ChangeColor()
    {
        NotifyObservers();
    }

    void IncreaseSize()
    {
        currentScale += 1;
        NotifyObservers();
    }

    void DecreaseSize()
    {
        currentScale -= 1;
        NotifyObservers();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            colorNum = 1;
            ChangeColor();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorNum = 2;
            ChangeColor();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            colorNum = 3;
            ChangeColor();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            colorNum = 4;
            ChangeColor();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            IncreaseSize();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            DecreaseSize();
        }
    }
}
