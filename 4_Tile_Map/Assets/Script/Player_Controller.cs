using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public static bool go_left = false;
    public static bool go_right = false;

    // Update is called once per frame
    void Update()
    {
        go_left = false;
        go_right = false;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //위치 조절 
            //transform.Translate(Vector3.up * 5.0f, Space.World);

            //속도 조절 
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5, 0);


        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            go_left = true; 
            GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);


        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            go_right = true; 
            GetComponent<Rigidbody2D>().velocity = new Vector3(2, 0, 0);
        }


    }
}
