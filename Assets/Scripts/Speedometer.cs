using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public ExamplePlayerController target;

    public float maxSpeed = 0.0f;

    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;

    [Header("UI")]
    public TMP_Text speedLabel;
    public RectTransform arrow;

    private float speed = 0.0f;

    private void Update()
    {
        if (target != null)
        {
            speed = target.CurrentSpeed * 3.6f; 

            if (speedLabel != null)
                speedLabel.text = ((int)speed+12) + " km/h";
            if (arrow != null)
                arrow.localEulerAngles =
                    new Vector3(0, 0, Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed));
        }
    }
}