using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtr5 : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    Vector3 moveDir = Vector3.zero;

    int speed = 3;
    int rotation_speed = 2;

    float gravity = 0.0f;
    float jumpSpeed = 5;

    Text numOBanana;
    GameObject txtObj;
    int acquiredNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        txtObj = GameObject.Find("NumText");
        numOBanana = txtObj.GetComponent<Text>();

        numOBanana.text = acquiredNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir.z = Input.GetAxis("Vertical") * speed;

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotation_speed, 0);

        Vector3 globalDir = transform.TransformDirection(moveDir);

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.run"))
            if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
                animator.SetTrigger("Run");

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.run"))
            if (moveDir.z > 0 || moveDir.z < 0)
                animator.SetTrigger("Run");

        if ((Input.GetAxis("Horizontal") == 0) && (Input.GetAxis("Vertical") == 0))
            animator.SetTrigger("Idle");

        if (controller.isGrounded)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravity = 10.0f;
                Debug.Log("pressed");

                moveDir.y = jumpSpeed;
            }

        if (moveDir.y <= 0.0f)
        {
            moveDir.y = 0.0f;
            gravity = 0.0f;
        }
        else gravity -= 0.4f;

        moveDir.y += gravity * Time.deltaTime;
        controller.Move(globalDir * Time.deltaTime);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("BANANA"))
        {
            acquiredNum += 1;
            Destroy(hit.gameObject, 0.0f);
            numOBanana.text = acquiredNum.ToString();
        }
    }
}