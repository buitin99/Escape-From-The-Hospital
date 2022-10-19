using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreeLookPlayer : MonoBehaviour
{
    private CharacterController _player;
    public Transform transformcamera;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transformcamera.transform.position = _player.transform.position;
    }
}
