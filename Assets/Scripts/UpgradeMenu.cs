using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    public bool menuActive;
    public Checkpoint activeCheckpoint;
    public static UpgradeMenu Instance;

    [SerializeField]
    GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        if (!menuActive) return;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            Close();
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Close();
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            Close();
        }
    }


    public void Open(Checkpoint checkpoint)
    {
        menu.SetActive(true);
        menuActive = true;
        activeCheckpoint = checkpoint;
        CharacterController2D.Instance.canMove = false;
    }

    public void Close()
    {
        menu.SetActive(false);
        menuActive = false;


        activeCheckpoint.MakeUnavailable();
        CharacterController2D.Instance.canMove = true;
    }
}
