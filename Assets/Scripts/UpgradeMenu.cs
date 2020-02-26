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

    [SerializeField]
    Upgrade upgrade1, upgrade2, upgrade3;

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
            UpgradeManager.Instance.HandleUpgrade(upgrade1);
            Close();
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            UpgradeManager.Instance.HandleUpgrade(upgrade2);
            Close();
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            UpgradeManager.Instance.HandleUpgrade(upgrade3);
            Close();
        }
    }


    public void Open(Checkpoint checkpoint)
    {
        menu.SetActive(true);
        menuActive = true;
        activeCheckpoint = checkpoint;
        CharacterController2D.Instance.canMove = false;

        //Get new upgrades
        upgrade1 = (Upgrade)UpgradeManager.Instance.GetNewUpgrade();
    }

    public void Close()
    {
        menu.SetActive(false);
        menuActive = false;


        activeCheckpoint.MakeUnavailable();
        CharacterController2D.Instance.canMove = true;
    }
}
