using System.Collections;
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
    }
}
