using UnityEngine;

public class TriggerEnd : MonoBehaviour
{

    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            gameManager.CompleteLevel();
        }
    }
}
