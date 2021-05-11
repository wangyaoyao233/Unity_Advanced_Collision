using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    /* public */

    /* private */
    private Transform startPoint;
    private Transform endPoint;
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        startPoint = transform.GetChild(0);
        endPoint = transform.GetChild(1);
    }

    // Update is called once per frame
    private void Update()
    {
        lineRenderer.SetPosition(0, startPoint.position);
        lineRenderer.SetPosition(1, endPoint.position);
    }
}