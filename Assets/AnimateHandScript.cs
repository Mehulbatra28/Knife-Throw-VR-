using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandScript : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty PinchValue;
    public Animator animator;

    private void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();
        float grip=PinchValue.action.ReadValue<float>();
        animator.SetFloat("Trigger", trigger);
        animator.SetFloat("Grip",grip);
    }
}
