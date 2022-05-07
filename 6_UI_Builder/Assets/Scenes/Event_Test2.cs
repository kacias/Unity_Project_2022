using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;



public class Event_Test2 : MonoBehaviour
{

    public Button LevelButton;
    public Button LevelButton2;

    public UnityEvent Explosion_Event;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        LevelButton = root.Q<Button>("Level1");
        LevelButton2 = root.Q<Button>("Level2");

        LevelButton.clicked += LevelButtonPresed;
        LevelButton2.clicked += LevelButtonPresed2;

    }

    void LevelButtonPresed()
    {
        Debug.Log("Level1 loaded");
    }

    void LevelButtonPresed2()
    {
        Explosion_Event.Invoke();
    }


}
