using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    float startTime = 0.0f;
    float speed = 3.0f;

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
        startTime += Time.deltaTime;

        if (startTime <= 3.0f)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
