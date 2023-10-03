using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class alev : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public GameObject kivilcim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int triggerValue = pinchAnimationAction.action.ReadValue<int>();
        if(triggerValue>0)
        {
            kivilcim.SetActive(true);
        }

        
    }
}
