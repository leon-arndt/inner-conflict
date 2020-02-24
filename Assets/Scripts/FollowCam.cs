using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Follow the player
public class FollowCam : MonoBehaviour
{
    public static FollowCam Instance;
    public bool followPlayer = false;
    public float posSmoothTime = 0.2f;
    private Vector3 moveVelocity = Vector3.zero;

    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!followPlayer) return;

        //position on player
        Vector3 targetPos = CharacterController2D.Instance.transform.position;
        Vector3 smoothPos = Vector3.SmoothDamp(transform.position, targetPos, ref moveVelocity, posSmoothTime);
        float zPos = transform.position.z;
        transform.position = new Vector3(smoothPos.x, smoothPos.y, zPos);
        
    }
}
