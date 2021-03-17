using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        Rigidbody rigibody;
        rigibody = gameObject.GetComponent<Rigidbody>();
        rigibody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I am Update!");
    }
}
