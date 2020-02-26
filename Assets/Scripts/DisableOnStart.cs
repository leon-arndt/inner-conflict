using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simply disable the gameobject on start.
/// Helpful for GameObjects in the UI working as groups (in case developer forgets to disable and saves scene)
/// </summary>
public class DisableOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }
}
