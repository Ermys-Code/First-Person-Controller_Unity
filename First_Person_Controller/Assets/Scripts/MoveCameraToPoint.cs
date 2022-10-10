using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToPoint : MonoBehaviour
{
    public Transform cameraPoint;

    private Transform cameraTransform;

    private void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        cameraTransform.position = cameraPoint.position;
        cameraTransform.rotation = cameraPoint.rotation;
    }
}
