using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DrawCircle : MonoBehaviour
{
    public int segments;

    public PlayerMove playerMove;

    public float width;
    LineRenderer line;

    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.positionCount = (segments + 1);
        line.useWorldSpace = false;
        line.startWidth = width;
    }

    private void Update()
    {
        CreatePoints();
    }

    void CreatePoints()
    {
        float x;
        float y;
        float z = 0f;

        float angle = 20f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Cos(Mathf.Deg2Rad * angle) * playerMove.radius;
            y = Mathf.Sin(Mathf.Deg2Rad * angle) * playerMove.radius;

            line.SetPosition(i, new Vector3(x, y, z));
            angle += (360f / segments);
        }
    }
}



