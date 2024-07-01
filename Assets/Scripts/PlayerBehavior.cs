using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerBehavior : MonoBehaviour
{
    public float gravity = StartSettings.gravity;
    public float speed = 10f;

    public CharacterController characterController;
    void Start()
    {
        
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);
    }
}
