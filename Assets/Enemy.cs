using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private float detectionRange = 20f;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distancePlayer =
            Vector3.Distance(player.position, transform.position);
        if (distancePlayer < detectionRange)
        {
            agent.SetDestination(player.position);
        }
    }
}
