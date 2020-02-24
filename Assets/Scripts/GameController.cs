using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the game structure
/// </summary>
public class GameController : MonoBehaviour
{
    public static GameController Instance;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinishBoss()
    {
        FollowCam.Instance.followPlayer = true;
    }
}
