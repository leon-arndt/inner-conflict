using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    public static UpgradeMenu Instance;

    [SerializeField]
    GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }


    public void Open()
    {
        menu.SetActive(true);
    }
}
