using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 



public class UI_Mananger : MonoBehaviour
{
    public static bool bCheck_Parameter = true;
    public static int bHardware = 1;

       

    [SerializeField] private TMP_InputField Name_Input;
    [SerializeField] private TMP_InputField Password_Input;
    public Slider Slider_Value; 


    public void MySilder()
    {
        Debug.Log("슬라이더가 움직입니다" + Slider_Value.value); 

    }




    public void MyButtonScript()
    {

        Debug.Log("My Button is pressed");


    }

    public void MyCheckButtonScript()
    {
        if (bCheck_Parameter == true)
        {
            bCheck_Parameter = false; 


        }
        else if (bCheck_Parameter == false)
        {

            bCheck_Parameter = true;


        }

        Debug.Log("My Check button:" + bCheck_Parameter); 


    }


    public void MyRadioButton0()
    {
        if (bHardware == 2)
        {
            bHardware = 1;
            Debug.Log("DirectX is selected" + bHardware);

        }

    }


    public void MyRadioButton1()
    {
        if (bHardware == 1)
        {
            bHardware = 2;
            Debug.Log("OpenGL is selected" + bHardware);
        }

    }


    public void MyInputField_Name()
    {

        Debug.Log("이름을 입력했습니다");
        if(Name_Input.text == "Kang")
        {
            Debug.Log("존재하는 ID입니다"); 
        }
    }


    public void MyInputField_Password()
    {

        Debug.Log("암호를 입력했습니다");
        if (Name_Input.text == "111")
        {
            Debug.Log("암호가 일치합니다");
        }
    }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
