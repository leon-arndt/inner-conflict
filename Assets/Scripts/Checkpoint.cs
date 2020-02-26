using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool activated;
    public bool available;

    private Color normalColor;

    // Start is called before the first frame update
    void Start()
    {
        normalColor = GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (activated) return;
        if (collision.GetComponent<CharacterController2D>())
        {
            //must be the player
            Activate();
        }
    }

    void MakeAvailable()
    {
        GetComponent<SpriteRenderer>().color = normalColor;
        available = true;
    }

    void Activate()
    {
        activated = true;
        UpgradeMenu.Instance.Open(this);
    }

    public void MakeUnavailable()
    {
        available = false;
        GetComponent<SpriteRenderer>().color = Color.black;
    }
}
