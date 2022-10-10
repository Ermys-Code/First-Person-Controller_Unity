using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraWithMouse : MonoBehaviour
{
    public float mouseSensitivity;
    public Transform cameraAxis;

    private float xRotation = 0f;

    void Start()
    {

    }

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * GetMouseMovementX());
        cameraAxis.transform.localRotation = Quaternion.Euler(GetMouseMovementY(), 0f, 0f);
    }

    private float GetMouseMovementX()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        return mouseX;
    }

    private float GetMouseMovementY()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        return xRotation;
    }
}
