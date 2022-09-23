using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onDoorWayTriggerEnter += OnDoorwayOpen;
        GameEvents.current.onDoorWayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen()
    {
        LeanTween.moveLocalY(gameObject, 5f, 1f).setEaseOutQuad();
    }

    private void OnDoorwayClose()
    {
        LeanTween.moveLocalY(gameObject, -0.6053848f, 1f).setEaseInQuad();
    }

    private void OnDestroy() 
    {
        GameEvents.current.onDoorWayTriggerEnter -= OnDoorwayOpen;
        GameEvents.current.onDoorWayTriggerExit -= OnDoorwayClose;  
    }
}
