using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverSphere : MonoBehaviour, IReceiver
{
    public Color color;
    private Renderer mR;
    private GameObject objectEffector;
    public ObjectEffector oE;

    // Start is called before the first frame update
    void Start()
    {
        objectEffector = GameObject.Find("ObjectEffector");
        oE = objectEffector.GetComponent<ObjectEffector>();

        mR = GetComponent<Renderer>();

        oE.RegisterObservers(this);
    }

    public void UpdateData(float currentScale, float maxScale, int colorVal)
    {
        switch (colorVal)
        {
            case 1:
                color = new Color(255, 0, 0);
                break;

            case 2:
                color = new Color(0, 255, 0);
                break;

            case 3:
                color = new Color(0, 0, 255);
                break;

            case 4:
                color = new Color(255, 255, 0);
                break;

            default:
                color = new Color(255, 255, 255);
                break;
        }

        //gameObject.GetComponent<Material>().SetColor(0 , color);
        mR.material.SetColor("Test_Material", color);

        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
        Debug.Log(currentScale + " " + color);
    }
}
