using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    void OnPlayerDtection()
    {
        Debug.Log("Red Alert");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void OnPlayerDie()
    {
        Debug.Log("Player Dead");
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    void OnPlayerExitDetection()
    {
        Debug.Log("Exit Detection");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

}
