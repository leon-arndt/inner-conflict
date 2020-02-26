using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTracker : MonoBehaviour
{
    public Vector3 normalLocalPos;
    public Transform lookTarget;
    public float maxMove;
    // Start is called before the first frame update
    void Start()
    {
        normalLocalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //Move towards the target
        transform.localPosition = normalLocalPos;

        Vector3 dirVector = lookTarget.position - transform.position;
        dirVector = dirVector.normalized * maxMove;
        transform.localPosition = normalLocalPos + dirVector;
    }
}
