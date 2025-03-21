using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    public float detectionRange = 20f;
    public float attackRange = 1f;
    public float attackCooldown = 1f;
    private float nextAttackTime = 0f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distancePlayer = Vector3.Distance(player.position, transform.position);
        if (distancePlayer < detectionRange)
        {
            agent.SetDestination(player.position);

            if (distancePlayer <= attackRange && Time.time >= nextAttackTime)
            {
                Hp playerHp = player.GetComponent<Hp>();
                if (playerHp != null)
                {
                    Debug.Log(playerHp.currentHp);
                    if (playerHp.currentHp > 0)
                    {
                        playerHp.Damage(1);
                        Debug.Log("플레이어에게 대미지를 주었습니다!");
                    }
                }

                nextAttackTime = Time.time + attackCooldown;
            }
        }
    }
}
