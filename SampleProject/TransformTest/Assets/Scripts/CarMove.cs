using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    float startTime = 0.0f;
    float speed = 3.0f;
    float rot = 90f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.forward);
        Debug.Log("distance= " + this.transform.position.z);

        transform.position += new Vector3(0, 0, 1f*speed);
        Debug.Log("distance= " + this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.up * -rot * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.up * rot * Time.deltaTime);

        startTime += Time.deltaTime;

        if (startTime <= 3.0f)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
