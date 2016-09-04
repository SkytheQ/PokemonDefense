using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private float speed = 1f;

    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {
        Debug.Log("speed =" + speed);
        //zet naar eerste waypoint
        target = Waypoints.points[0];

    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //als target positie minder dan of gelijk is aan 0.2 units, ga naar volgende waypoint.
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }
}
