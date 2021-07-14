using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGizmos : MonoBehaviour
{
    public void OnDrawFizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}
