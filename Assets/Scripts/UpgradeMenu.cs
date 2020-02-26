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

    [SerializeField]
    UiUpgrade uiUpgrade1, uiUpgrade2, uiUpgrade3;

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

        //Get new upgrades, clean up and make more abstract, less hard coded (array, linked structure pair?)
        upgrade1 = (Upgrade)UpgradeManager.Instance.GetNewUpgrade();
        uiUpgrade1.UpdateData(upgrade1);

        upgrade2 = (Upgrade)UpgradeManager.Instance.GetNewUpgrade();
        uiUpgrade2.UpdateData(upgrade2);

        upgrade3 = (Upgrade)UpgradeManager.Instance.GetNewUpgrade();
        uiUpgrade3.UpdateData(upgrade3);
    }

    public void Close()
    {
        menu.SetActive(false);
        menuActive = false;


        activeCheckpoint.MakeUnavailable();
        CharacterController2D.Instance.canMove = true;
    }
}
