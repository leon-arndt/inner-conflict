using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public Object[] upgradePool;
    public List<string> unlockedUpgrades;

    // Start is called before the first frame update
    void Start()
    {
        upgradePool = Resources.LoadAll("Upgrades", typeof(Upgrade));
        //Resources.FindObjectsOfTypeAll<Upgrade>();
    }


    void HandleUpgrade(Upgrade upgrade)
    {
        if (upgrade.upgradeName == "boy")
        {
            //do something
        }
    }

    void GetNewUpgrades()
    {

    }
}
