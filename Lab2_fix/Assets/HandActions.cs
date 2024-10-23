using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandActions : MonoBehaviour
{
    private Animator animator;
    public InputActionProperty gripAction;
    public InputActionProperty triggerAction;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            
            if (Input.GetKeyDown(KeyCode.P))
            {
                animator.SetTrigger("point");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                animator.SetTrigger("rest");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("fist");
            }
            

            float gripValue = gripAction.action.ReadValue<float>();
            float triggerValue = triggerAction.action.ReadValue<float>();

            animator.SetFloat("Grip", gripValue);
            animator.SetFloat("Trigger", triggerValue);
        }
    }
}
