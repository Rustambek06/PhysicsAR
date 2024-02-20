using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class RotationPrefab : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float horizontalMovement = touch.deltaPosition.x;
                float verticalMovement = touch.deltaPosition.y;

                transform.Rotate(verticalMovement * rotationSpeed, -horizontalMovement * rotationSpeed, 0f);
            }
        }
    }
}
