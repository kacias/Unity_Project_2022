using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderTest : MonoBehaviour
{
    private LineRenderer lineRenderer; 


    // Start is called before the first frame update
    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetColors(Color.red, Color.yellow);
        lineRenderer.SetWidth(0.1f, 0.1f);

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position + new Vector3(0, 100, 0)); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
