using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorOpen : MonoBehaviour
{
    [SerializeField]
    private GameObject _key;

    [SerializeField]
    private GameObject _triggerArea;
   
   private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            _key.SetActive(false);
            _triggerArea.SetActive(true);
        }
    }
}
