using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player : MonoBehaviour
{
    public GameObject obj; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0.0f, 0.1f, 0.0f); 
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0.0f, -0.1f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1.0f, 0.0f, 0.0f);
        }        
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1.0f, 0.0f, 0.0f);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(obj, transform.position, Quaternion.identity); 
        }


    }
}
