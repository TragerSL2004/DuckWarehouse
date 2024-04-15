using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementBehaviour : MonoBehaviour
{
    public Transform _target;

    NavMeshAgent _agent;

    public Transform Target
    {
        get
        {
            return _target;
        }
    }


    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        //If a target hasn't been set return
        if (!_target)
            return;

        _agent.destination = _target.position;

        print(_target.position);
    }
}
