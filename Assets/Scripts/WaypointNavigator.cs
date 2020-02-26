using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    public Waypoint[] waypoints;
    public Waypoint currentWaypoint;
    public int currentWaypointIndex = 0;

    public float m_moveSpeed = 1f;
    private float m_minWaypointDistance = 1f;

    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = waypoints[currentWaypointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        //follow waypoints if not aggressive or pacified
        if (waypoints.Length > 1)
        {
            WalkTowardsWaypoint();
            CheckIfWaypointReached();
        }
    }

    public void WalkTowardsWaypoint()
    {
        //step towards target
        Vector3 targetPos = currentWaypoint.transform.position;
        float step = m_moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

        //look toward target
        Vector3 dir = targetPos - transform.position;
    }

    private void CheckIfWaypointReached()
    {
        float distance = Vector3.Distance(transform.position, currentWaypoint.transform.position);
        if (distance < m_minWaypointDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            currentWaypoint = waypoints[currentWaypointIndex];
            //Debug.Log("Enemy reached checkpoint");
        }
    }
}
