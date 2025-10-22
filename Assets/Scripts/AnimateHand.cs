using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    public InputActionProperty PinchAnim;
    public InputActionProperty GripAnim;
    public Animator HandAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("animate hands script is working ");
    }

    // Update is called once per frame
    void Update()
    {
        float TriggerValue = PinchAnim.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger",TriggerValue);
        Debug.Log(TriggerValue);
        float GripValue=PinchAnim.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip",GripValue);

    }
}
