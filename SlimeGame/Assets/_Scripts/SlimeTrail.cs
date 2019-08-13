using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeTrail : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform point0;
    public Transform point1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, point0.position);
        lineRenderer.SetPosition(2, point1.position);
        lineRenderer.SetPosition(1, (point1.position + point0.position) / 2);
    }
}
