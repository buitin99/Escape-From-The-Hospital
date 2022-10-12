using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemysNavMesh : MonoBehaviour
{
    public Transform[] _listPositionTransforms;
    private int _wayPointIndex;
    private Vector3 _target;
    private NavMeshAgent _navMeshAgent;
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _characterController = FindObjectOfType<CharacterController>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance._isGameHashGameOver)
        {
            if(!TriggerCameraFollow.isTrigger)
            {
                if(_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
                {
                    IterateWayPointIndex();
                    UpdateDestination();
                }
            }
            else if (TriggerCameraFollow.isTrigger)
            {
                _navMeshAgent.SetDestination(_characterController.transform.position);
            }  
        }
        else
            _navMeshAgent.isStopped = true;
    }

    void UpdateDestination()
    {
        _target = _listPositionTransforms[_wayPointIndex].position;
        _navMeshAgent.SetDestination(_target);
    }

    void IterateWayPointIndex()
    {
        _wayPointIndex++;
        if (_wayPointIndex == _listPositionTransforms.Length)
        {
            _wayPointIndex = 0;
        }
    }
}
