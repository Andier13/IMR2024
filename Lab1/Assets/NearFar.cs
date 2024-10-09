using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearFar : MonoBehaviour
{
    private Animator animator;

    public Transform otherCharacter;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Animator>(out animator))
        {
            Debug.Log("Animator not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("Far");
                Debug.Log("Pressed F");
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                animator.SetTrigger("Near");
                Debug.Log("Pressed N");
            }

            /*
             * if (Vector3.Distance(transform.position, otherCharacter.transform.position) <= 0.25)
            {
                animator.SetTrigger("Near");
            }
            else
            {
                animator.SetTrigger("Far");
            }
             */
        }
    }
}
