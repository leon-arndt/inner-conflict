using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterController2D>())
        {
            CharacterController2D.Instance.Respawn();
        }
    }
}
