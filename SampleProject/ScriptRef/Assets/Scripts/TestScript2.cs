using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    public int a = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(a);
    }

    public void TestScript2Func()
    {
        Debug.Log("다른 오브젝트 스크립트 함수 호출");
    }
}
