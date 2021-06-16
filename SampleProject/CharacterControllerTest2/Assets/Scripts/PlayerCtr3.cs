using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr3 : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    Vector3 moveDir = Vector3.zero;

    int speed = 3;
    int rotation_speed = 2;

    float gravity = 0.0f;
    float jumpSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir.z = Input.GetAxis("Vertical") * speed;

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotation_speed, 0);

        Vector3 globalDir = transform.TransformDirection(moveDir);

    }
}
