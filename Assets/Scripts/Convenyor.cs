using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convenyor : MonoBehaviour
{
    public LayerMask layer;
    CharacterController _characterController;
    [SerializeField]
    private float _speed = 0.0001f;
    Rigidbody rb;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _characterController = FindObjectOfType<CharacterController>();

    }

    private void Update() 
    {
        pos = rb.position;
        // rb.position += Vector3.back*speed*Time.deltaTime;
        // rb.MovePosition(pos); 
                
    }

     private void OnTriggerStay(Collider other) {    
        if((layer & (1 << other.gameObject.layer)) != 0) {
            _characterController.Move(pos*_speed); 
            Debug.Log(_characterController.transform.position.ToString());
        }
    }
}
