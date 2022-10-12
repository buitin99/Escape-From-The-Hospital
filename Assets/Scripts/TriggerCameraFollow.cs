using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraFollow : MonoBehaviour
{
    public LayerMask layerCamera;

    public static bool isTrigger;

    private void OnTriggerStay(Collider other) {
        if((layerCamera & (1 << other.gameObject.layer)) != 0) {
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        isTrigger = false;
    }


}
