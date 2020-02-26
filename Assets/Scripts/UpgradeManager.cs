using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Has references to a pool of upgrades
/// </summary>
public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;

    public Object[] upgradePool;
    public List<string> acquiredUpgrades;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        upgradePool = Resources.LoadAll("Upgrades", typeof(Upgrade));
    }


    public void HandleUpgrade(Upgrade upgrade)
    {
        Debug.Log(upgrade.upgradeName + " - upgrade was chosen");
        acquiredUpgrades.Add(upgrade.name);
        if (upgrade.upgradeName == "boy")
        {
            //do something
        }
    }

    public Object GetNewUpgrade()
    {
        Object upgrade = upgradePool[Random.Range(0, upgradePool.Length)];
        return upgrade;
    }
}
