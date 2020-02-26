using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
