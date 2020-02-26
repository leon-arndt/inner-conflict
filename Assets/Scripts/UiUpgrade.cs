using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Mixed UI and data class for displaying data for the upgrades
/// </summary>
public class UiUpgrade : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateData(Upgrade data)
    {
        nameText.text = data.upgradeName;
    }
}
