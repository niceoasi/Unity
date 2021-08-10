using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    float h, v;
    float speed = 3.0f;

    public void OnTouchValueChanged(Vector2 stickPos)
    {
        h = stickPos.x;
        v = stickPos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (h != 0f && v != 0f)
        {
            transform.Rotate(0, h, 0);
            transform.Translate(0, 0, v * speed * Time.deltaTime);
        }
    }
}
