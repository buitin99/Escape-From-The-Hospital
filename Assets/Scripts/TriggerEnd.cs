using UnityEngine;

public class TriggerEnd : MonoBehaviour
{  
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CompleteLevelDisplay();
        }
    }
}
