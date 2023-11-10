using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPos = target.position;
        newPos.z = -10;

        transform.position = newPos;
    }
}
