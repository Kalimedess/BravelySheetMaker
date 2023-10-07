using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetChoiceControl : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 desiredPosition;
    private void Start()
    {
        cameraTransform = gameObject.transform;
        desiredPosition = transform.position;
    }
    public void SwitchSheetToRight()
    {
        desiredPosition.x += 22;
        cameraTransform.position = desiredPosition;
    }
    public void SwitchSheetToLeft() {
        desiredPosition.x -= 22;
        cameraTransform.position = desiredPosition;
    }
}
