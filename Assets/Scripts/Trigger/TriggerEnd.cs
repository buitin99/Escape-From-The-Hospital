using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    public int idLevel;
    private PlayerData playerData;

    private void Awake() 
    {
        playerData = PlayerData.Load();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            playerData.totalLevel = idLevel;
            playerData.SaveData();
            GameManager.Instance.CompleteLevelDisplay();
        }
    }
}
