using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0.0f, 0.0f, -0.01f); 

        if (transform.position.z < -5.0f)
        {
            Destroy(gameObject, 0);
        }
        
    }

}
