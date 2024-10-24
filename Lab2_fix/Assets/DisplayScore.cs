using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public Transform startPoint;
    public Transform ball;
    private TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<TextMeshProUGUI>(out textMeshProUGUI))
        {
            Debug.Log("Couldn't get TextMeshPro component");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (textMeshProUGUI != null)
        {
            var distance = Vector3.Distance(startPoint.position, ball.position);
            textMeshProUGUI.text = "Score: " + distance.ToString("0.00");
        }   
    }
}
