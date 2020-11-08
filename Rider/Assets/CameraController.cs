using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform bike;

    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 newPosition = bike.position + offset;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
