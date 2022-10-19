using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLaserOff : MonoBehaviour
{
    [SerializeField]
    private GameObject _laser;

    [SerializeField]
    private GameObject _lightSaber;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            _laser.SetActive(false);
            _lightSaber.SetActive(false);
        }
    }
}
