using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class QuadraticBezierCurve : MonoBehaviour
{
    public Transform[] points;
    
    private LineRenderer lineRenderer;
    private int numSegments = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DrawQuadraticBezierCurve();
    }

    private void DrawQuadraticBezierCurve()
    {
        Vector3[] lineVertices = new Vector3[numSegments + 1];
        for (int i = 0; i <= numSegments; i++)
        {
            float t = i / (float)numSegments;
            Vector3 pixel = CalculateQuadraticBezierPoint(t, points[0].position, points[1].position, points[2].position);
            lineVertices[i] = pixel;
        }
        lineRenderer.positionCount = lineVertices.Length;
        lineRenderer.SetPositions(lineVertices);
    }

    Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        Vector3 p = (1 - t) * (1 - t) * p0 + 2 * (1 - t) * t * p1 + t * t * p2;
        return p;
    }
}
