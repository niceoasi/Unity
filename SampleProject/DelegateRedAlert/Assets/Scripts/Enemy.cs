using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnEnable()
    {
        Player.OnPlayerEvent += this.OnPlayerDetection;
    }

    private void OnDisable()
    {
        Player.OnPlayerEvent -= this.OnPlayerDetection;
    }

    void OnPlayerDetection()
    {
        Debug.Log("Red Alert");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
