using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.01f, 0.0f, 0.0f);

    }

    public void Move_Left()
    {
        transform.Translate(3.0f, 0.0f, 0.0f); 

    }
}
