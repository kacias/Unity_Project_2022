using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        if (Player_Controller.go_left == true)
        {
            transform.Translate(Vector3.right * 0.05f, Space.World);
        }
        
        if (Player_Controller.go_right == true)
        {
            transform.Translate(Vector3.left * 0.05f, Space.World);

        }

    }
}
