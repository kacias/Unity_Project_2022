using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Level_Manager : MonoBehaviour
{
    public GameObject obj; 

    // Start is called before the first frame update
    void Start()
    {
        for (int j=0; j<5; j++)
        {
            float randomZ = Random.Range(30.0f, 50.0f);
            for (int i = 0; i < 5; i++)
            {
                float randomX = Random.Range(-10.0f, 10.0f);
                Instantiate(obj, new Vector3(randomX, 8.0f, randomZ), Quaternion.identity);
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {



    }
}
