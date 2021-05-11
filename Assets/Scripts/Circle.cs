using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{
    /* public */

    [Min(0.2f)]
    public float Radius = 1.5f;

    /* private */
    private SpriteRenderer sr;
    private Transform slider;

    // Start is called before the first frame update
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        slider = GameObject.Find("Canvas").transform.GetChild(0);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.localScale = new Vector3(Radius * 2, Radius * 2, 1.0f);
    }

    public void SetColor(Color color)
    {
        sr.color = color;
    }

    public void SetScaleFromSlider()
    {
        Radius = slider.gameObject.GetComponent<Slider>().value;
    }
}