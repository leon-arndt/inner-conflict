using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = PlayerCombat.Instance.transform.localRotation;   

        //Flip if player is facing left
        if (!CharacterController2D.Instance.m_FacingRight)
        {
            moveSpeed *= -1f;
        }

        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * transform.right);
    }
}
