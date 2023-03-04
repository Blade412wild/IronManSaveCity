using Oculus.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty GripAnimation;
    public Animator HandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);
        float gripValue = GripAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", gripValue);
    }
}
