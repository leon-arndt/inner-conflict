using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minishame : MonoBehaviour
{
    float activationDelay;

    // Start is called before the first frame update
    void Start()
    {
        activationDelay = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        activationDelay -= Time.deltaTime;

    }

    void Activate()
    {

    }
}
