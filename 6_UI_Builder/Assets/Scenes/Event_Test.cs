using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class Event_Test : MonoBehaviour
{
    public UnityEvent Explosion_Event; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explosion();
        }            
    }

    private void Explosion()    
    {
        Explosion_Event.Invoke();
        Debug.Log("Æø¹ß¹ß»ý!"); 
    }
   
}
