using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public event Action onDoorWayTriggerExit;
    private void Awake() {
        current = this;
    }

    public event Action onDoorWayTriggerEnter;

    public void DoorwayTriggerEnter()
    {
        if(onDoorWayTriggerEnter != null)
        {
            onDoorWayTriggerEnter();
        }
    }

    public void DoorwayTriggerExit()
    {
        if(onDoorWayTriggerExit != null)
        {
            onDoorWayTriggerExit();
        }
    }
}
