using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class DrawLines : MonoBehaviour
{
    private new Camera camera;

    public GameObject newObject;

    public Material lineMaterial;
    public float lineWidth;
    public float depth = 5f;
    private List<GameObject> lineList = new List<GameObject>();

    private Vector3? lineStartPoint = null;

    public GameObject lastGameObject;
    private LineRenderer lineRenderer;

    private void Start()
    {
        camera = GetComponent<Camera>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        //DrawLine(Color.blue);
        if (lineList != null)
        {
            lastGameObject = lineList[lineList.Count - 1];
        }

        for(int i = 0; i < lineList.Count; i++)
        {
            if(lineList[i] == null)
            {
                lineList.RemoveAt(i);
            }
        }
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

                 var lineObject = new GameObject("line");
                //Instantiate(newObject, gameObject.transform);

                var lineRenderer = lineObject.AddComponent<LineRenderer>();
                lineRenderer.material = lineMaterial;
                lineRenderer.startColor = color;
                lineRenderer.endColor = color;
                lineRenderer.SetPositions(new Vector3[] { lineStartPoint.Value, lineEndpoint });
                lineRenderer.startWidth = lineWidth;
                lineRenderer.endWidth = lineWidth;

            lineStartPoint = null;

            lineList.Add(lineObject);
        }
    }

    public GameObject GetLastLine()
    {

        return lastGameObject;
    }
}
