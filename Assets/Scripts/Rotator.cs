using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotate objects over time
/// </summary>
public class Rotator : MonoBehaviour
{
    public Vector3 rotVector;

    // Update is called once per frame
    void Update()
    {
        Vector3 current = transform.localEulerAngles;
        transform.localRotation = Quaternion.Euler(current + rotVector);
    }
}
