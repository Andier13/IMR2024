using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Transform currentPostion;
    private Rigidbody current_rigidbody;
    public Transform startPoint;
    private float startTime = 0.0f;
    void Start()
    {
        currentPostion = GetComponent<Transform>();
        if (!TryGetComponent<Rigidbody>(out current_rigidbody))
        {
            Debug.Log("Couldn't get Rigidbody component");
        }
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(startPoint.position, currentPostion.position);
        if (distance > 0.1f)
        {
            if (startTime == 0.0f)
            {
                startTime = Time.time;
            }

            if (Time.time - startTime >= 5.0f)
            {
                startTime = 0.0f;
                currentPostion.position = startPoint.position;
                current_rigidbody.velocity = Vector3.zero;
            }
        }
    }
}
