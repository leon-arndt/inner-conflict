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

        controller.Move(Input.GetAxisRaw("Horizontal"), false, false);

        if (Input.GetAxisRaw("Jump") > 0.1f)
        {
            controller.Move(0, false, true);
        }
    }
}
