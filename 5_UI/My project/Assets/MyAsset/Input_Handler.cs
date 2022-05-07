using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Input_Handler : MonoBehaviour
{
    public InputField Name_Input; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Input Text:" + Name_Input.text); 
        
    }

    public void Print_Status()
    {

        Debug.Log("Text Input filed was changed"); 

    }

}
