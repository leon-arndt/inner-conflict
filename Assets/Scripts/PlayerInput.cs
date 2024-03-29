﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController2D controller = CharacterController2D.Instance;

        if (!controller.canMove) return;

        controller.Move(Input.GetAxisRaw("Horizontal"), false);

        if (Input.GetAxisRaw("Jump") > 0.1f)
        {
            if (controller.m_Grounded)
            {
                PlayerAnimation.Instance.PlayStretch();
                controller.Move(0, true);
            }
        }

        if (Input.GetAxisRaw("Vertical") < -0.1f)
        {
            controller.SetCrouch(true);
        }
        else
        {
            controller.SetCrouch(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayerCombat.Instance.CreateBullet();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerCombat.Instance.CreateMelee();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            CharacterController2D.Instance.Respawn();
        }
    }
}
