using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class DrawLines : MonoBehaviour
{
    private new Camera camera;

    public Material lineMaterial;
    public float lineWidth;
    public float depth = 5f;

    private Vector3? lineStartPoint = null;

    private GameObject lastGameObject;
    private LineRenderer lineRenderer;

    private void Start()
    {
        camera = GetComponent<Camera>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        //DrawLine(Color.blue);
    }

    private Vector3 GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);

        return ray.origin + ray.direction * depth;
    }

    public void DrawLine(Color color)
    {
        if (Input.GetMouseButtonDown(0))
        {
            lineStartPoint = GetMouseCameraPoint();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (!lineStartPoint.HasValue)
            {
                return;
            }
            var lineEndpoint = GetMouseCameraPoint();
            if (color == Color.red)
            {
                var gameObject = new GameObject("red line");
            }

            if (color == Color.blue)
            {
                var gameObject = new GameObject("blue line");
            }
            //var lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.material = lineMaterial;
            lineRenderer.startColor = color;
            lineRenderer.endColor = color;
            lineRenderer.SetPositions(new Vector3[] { lineStartPoint.Value, lineEndpoint });
            lineRenderer.startWidth = lineWidth;
            lineRenderer.endWidth = lineWidth;


            lineStartPoint = null;

            lastGameObject = gameObject;

        }
    }

    public GameObject GetLastLine()
    {

        return lastGameObject;
    }
}
