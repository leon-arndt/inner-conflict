using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool activated;
    public bool available;

    // Start is called before the first frame update
    void Start()
    {
        
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

    void Activate()
    {
        activated = true;
        UpgradeMenu.Instance.Open();
    }
}
