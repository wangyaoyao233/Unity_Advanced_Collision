using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPoint : MonoBehaviour
{
    /* private */
    //private GameObject selectObj;
    //private bool isRun = false;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseDrag()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        transform.position = mouse;
    }
}