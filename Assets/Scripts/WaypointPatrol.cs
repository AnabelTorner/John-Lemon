using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    public GameObject player;

    public SafeZone safezone;

    int m_CurrentWaypointIndex;

    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    void Update()
    {
        if (safezone.m_IsPlayerAtSafeZone)
        {
            navMeshAgent.SetDestination(waypoints[1].position);
        }
        else
        {
            navMeshAgent.SetDestination(waypoints[0].position);
        }
    }
}
