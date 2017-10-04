using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
public class EnemyMove : MonoBehaviour
{

    private Transform playerTransform;
    private NavMeshAgent agent;
    private bool isFollowing = false;

    private void Awake()
    {
		agent = GetComponent<NavMeshAgent>();
        SendTransform.SendThisTransform += SendThisTransforHandler;
	}

    private void SendThisTransforHandler(Transform sendersTransform)
    {
        playerTransform = sendersTransform;
    }

    private void OnTriggerEnter(Collider other)
    {
        isFollowing = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isFollowing = false;
        agent.SetDestination(this.transform.position);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFollowing)
        {
            agent.SetDestination(playerTransform.position);
        }
    }
}
