using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCircle : MonoBehaviour
{
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCircleClick()
    {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
