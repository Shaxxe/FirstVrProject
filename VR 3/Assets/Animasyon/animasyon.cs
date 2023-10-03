using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animasyon : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator NewAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int triggerValue = pinchAnimationAction.action.ReadValue<int>();
        NewAnimator.SetInteger("Trigger", triggerValue);

        int gripValue = gripAnimationAction.action.ReadValue<int>();
        NewAnimator.SetInteger("Grip", gripValue);
    }
}
