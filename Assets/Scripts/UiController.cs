using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public static UiController Instance;

    [SerializeField]
    Image playerHealth;

    private float playerHealthMaxWidth;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        playerHealthMaxWidth = playerHealth.rectTransform.sizeDelta.x;
    }

    public void UpdatePlayerHealth(float ratio)
    {
        Vector2 currentDelta = playerHealth.rectTransform.sizeDelta;
        playerHealth.rectTransform.sizeDelta = new Vector2(playerHealthMaxWidth * ratio, currentDelta.y);
    }
}
