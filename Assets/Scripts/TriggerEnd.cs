using UnityEngine;

public class TriggerEnd : MonoBehaviour
{

    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider other) {
        gameManager.CompleteLevel();
    }
}
