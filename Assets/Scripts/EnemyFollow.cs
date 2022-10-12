using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
    //    player = FindObjectOfType<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
    //    if (TriggerCameraFollow.isTrigger)
    //    {
    //         enemy.SetDestination(player.position);
    //    }
    }
}
