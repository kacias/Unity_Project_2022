using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class UI_Builder_Script : MonoBehaviour
{

    public Button LevelButton;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        LevelButton = root.Q<Button>("Level1");
        LevelButton.clicked += LevelButtonPresed; 
                
    }

    void LevelButtonPresed()
    {
        Debug.Log("Level1 loaded"); 
    }


}
