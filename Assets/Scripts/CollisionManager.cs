using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    /* public */
    public GameObject Line;
    public GameObject Circle;

    /* private */

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (CollisionLineCircle(Line, Circle))
        {
            Circle.GetComponent<Circle>().SetColor(Color.red);
        }
        else
        {
            Circle.GetComponent<Circle>().SetColor(Color.white);
        }
    }

    private bool CollisionLineCircle(GameObject line, GameObject circle)
    {
        float r = Circle.GetComponent<Circle>().Radius;
        float cx = Circle.transform.position.x;
        float cy = Circle.transform.position.y;
        float p0x = Line.transform.GetChild(0).position.x;
        float p0y = Line.transform.GetChild(0).position.y;
        float p1x = Line.transform.GetChild(1).position.x;
        float p1y = Line.transform.GetChild(1).position.y;

        float dx, dy;
        { // 判断两个端点
            dx = p0x - cx;
            dy = p0y - cy;
            if ((dx * dx + dy * dy) < (r * r))
                return true;

            dx = p1x - cx;
            dy = p1y - cy;
            if ((dx * dx + dy * dy) < (r * r))
                return true;
        }
        float t0 = (cx - p0x) * (p1x - p0x) + (cy - p0y) * (p1y - p0y);
        float t1 = (p1x - p0x) * (p1x - p0x) + (p1y - p0y) * (p1y - p0y);
        if (t1 != 0)
        {
            float t = (float)t0 / t1;

            if (t >= 0.0f && t <= 1.0f)
            {
                // 根据t, 求出线段上垂点的坐标
                float vx = p0x + (p1x - p0x) * t;
                float vy = p0y + (p1y - p0y) * t;

                dx = vx - cx;
                dy = vy - cy;

                if ((dx * dx + dy * dy) < (r * r))
                    return true;
            }
        }

        return false;
    }
}