using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    float h, v;
    float speed = 3.0f;

    Animator mAvatar;

    public void OnTouchValueChanged(Vector2 stickPos)
    {
        h = stickPos.x;
        v = stickPos.y;
    }

    public void Start()
    {
        mAvatar = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mAvatar.SetFloat("Speed", (h * h + v * v));

        if (h != 0f && v != 0f)
        {
            transform.Rotate(0, h, 0);
            transform.Translate(0, 0, v * speed * Time.deltaTime);
        }
    }
}
