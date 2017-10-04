using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SharkAI : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform food;

    private void OnTriggerStay()
    {
        agent.SetDestination(food.position);
    }
}
