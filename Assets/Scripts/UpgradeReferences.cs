using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeReferences : MonoBehaviour
{
    public static UpgradeReferences Instance;


    private void Start()
    {
        Instance = this;
    }
}
