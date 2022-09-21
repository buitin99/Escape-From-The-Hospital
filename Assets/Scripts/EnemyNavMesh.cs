using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyNavMesh : MonoBehaviour
{
    public Transform[] _listPositionTransforms;
    private int _wayPointIndex;
    private Vector3 _target;
    private NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,_target) < 1)
        {
            IterateWayPointIndex();
            UpdateDestination();
        }
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
