using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    private LineRenderer lr;
    public float x = 8;
    public float y = 4;
    public float z = 10;

    // Start is called before the first frame update
    void Start()
    {
        //LineRenderer lr = gameObject.AddComponent<LineRenderer>();

        //lr.startWidth = 0.1f;
        //lr.endWidth = 0.1f;
        //lr.useWorldSpace = true;
        //lr.loop = true;

        //lr.SetPosition(0, new Vector3(x, y, z));
        //lr.SetPosition(0, new Vector3(-x, y, z));
        //lr.SetPosition(0, new Vector3(-x, -y, z));
        //lr.SetPosition(0, new Vector3(x, -y, z));

        //for (int i = 0; i < points.Length; i++)
        //{
        //    lr.SetPosition(i, points[i].position);
        //    Debug.Log(i);
        //}

        //lr.SetPositions(pos.ToArray());

        //lr = GetComponent<LineRenderer>();

        //SetUpLine(points);
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < points.Length; i++)
        //{
        //    lr.SetPosition(i, points[i].position);
        //}
    }
}
