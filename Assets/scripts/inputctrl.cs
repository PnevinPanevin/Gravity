using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class inputctrl : MonoBehaviour
    
{
    public UnityEvent jump;
    public UnityEvent left;
    public UnityEvent right;


    void Start()
    {
        
    }

  
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.W)) { 
                  right.Invoke();
        }
          
        if (Input.GetKeyDown(KeyCode.Space)) {
            jump.Invoke();
        }
    }
}
