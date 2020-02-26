using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ease of use component
/// </summary>
public class AutoDestroy : MonoBehaviour
{
    public float destroyDelay;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }
}
