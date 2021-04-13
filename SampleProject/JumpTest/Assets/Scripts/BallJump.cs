using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    float gravity = 0.0f;
    Vector3 YPos;

    // Start is called before the first frame update
    void Start()
    {
        YPos = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gravity = 10.0f;
        }

        YPos.y += gravity * Time.deltaTime;
        transform.position = YPos;
        Debug.Log(gravity);

        if(YPos.y <= 0.0f)
        {
            YPos.y = 0.0f;
            gravity = 0.0f;
        }

        gravity -= 0.4f;
    }
}
