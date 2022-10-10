using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public CharacterController controller;
    
    private float speed = 12f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + gameObject.transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
