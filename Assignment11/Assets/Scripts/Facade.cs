using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    public GameObject blueCircle;
    public GameObject redCircle;
    public GameObject greenCircle;

    private BlueCircle bc;
    private RedCircle rc;
    private GreenCircle gc;

    // Start is called before the first frame update
    void Start()
    {
        bc = blueCircle.GetComponent<BlueCircle>();
        rc = redCircle.GetComponent<RedCircle>();
        gc = greenCircle.GetComponent<GreenCircle>();
    }

    // Update is called once per frame
    void Update()
    {
        Interact();
    }

    void Interact()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gc.OnCircleClick();
        }

        if (Input.GetKey(KeyCode.D))
        {
            bc.OnCircleClick();
        }

        if (Input.GetKey(KeyCode.A))
        {
            rc.OnCircleClick();
        }
    }
}
