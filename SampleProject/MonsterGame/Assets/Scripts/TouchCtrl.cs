using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchCtrl : MonoBehaviour
{
    public HeroMove player;
    public float dragRadius = 50f;

    RectTransform touchCtrl;

    private int touchID = -1;
    private Vector2 startPos = Vector2.zero;
    private bool btnPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        touchCtrl = GetComponent<RectTransform>();
        startPos = touchCtrl.position;
    }

    public void TouchDown()
    {
        btnPressed = true;
    }

    public void TouchUp()
    {
        btnPressed = false;
        SendInputValue(startPos);
    }

    private void FixedUpdate()
    {
        HandleTouchPhase();

        #if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_WEBPLAYER || UNITY_STANDALONE_OSX
        SendInputValue(startPos);
        #endif
    }

    void HandleTouchPhase()
    {
        int i = 0;

        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                i++;

                Vector3 touchPos = new Vector3(touch.position.x, touch.position.y);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        if (touch.position.x <= (startPos.x + dragRadius))
                            touchID = i;
                        break;
                }
            }
        }
    }

    void SendInputValue(Vector2 inputPos)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
