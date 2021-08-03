using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health = 50;
    public float speed = 3f;

    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) Health = Health - 5;

        PlayerMove();

        if (Health <= 0) GameManager.instance.NotifyEvent(GameManager.EventType.Die);
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CHECKPOINT"))
        {
            GameManager.instance.NotifyEvent(GameManager.EventType.ExitTouch);
        }
    }

}
