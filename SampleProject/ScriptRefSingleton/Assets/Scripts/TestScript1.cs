using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestScript2.instance.a = 20;
        TestScript2.instance.TestScript2Func();
        TestScript2.instance.TestScript2Func();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
