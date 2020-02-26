using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public List<string> unlockedUpgrades;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void HandleUpgrade(Upgrade upgrade)
    {
        if (upgrade.upgradeName == "boy")
        {
            //do something
        }
    }
}
