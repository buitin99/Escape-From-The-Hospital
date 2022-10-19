using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleport : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerGO;
    [SerializeField]
    private Transform _destination;
    [SerializeField]
    private Transform _player;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            _playerGO.SetActive(false);
            _player.position = _destination.position;
            _playerGO.SetActive(true);
        }
    }
}
