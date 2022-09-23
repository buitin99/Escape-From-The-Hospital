using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            GameEvents.current.DoorwayTriggerEnter();
        }
    }

    private void OnTriggerExit(Collider other) {
        GameEvents.current.DoorwayTriggerExit();
    }
}
