using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public GameObject obj;
    private int counter; 

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        ++counter; 

        if (counter < 20)
        {
            float randomX = Random.Range(-10.0f, 5.0f);
            Instantiate(obj, new Vector3(randomX, 2.5f, 30.0f), Quaternion.identity);

        }

        
    }
}
