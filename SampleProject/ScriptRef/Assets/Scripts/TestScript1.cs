using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Obj2");
        obj.GetComponent<TestScript2>().a = 20;
        obj.GetComponent<TestScript2>().TestScript2Func();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
