using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    private Transform movePositionTransform;


    private NavMeshAgent navMeshAgent;


    private void Awake()
    {
        movePositionTransform = GameObject.Find("FirstPersonPlayer").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();


    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }




}
