using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReceiver
{

    // Update is called once per frame
    void UpdateData(float currentScale, float maxScale, int colorVal);

}
