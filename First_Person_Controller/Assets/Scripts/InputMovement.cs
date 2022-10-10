using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    public CharacterController controller;

    private float speed = 12f;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + gameObject.transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
