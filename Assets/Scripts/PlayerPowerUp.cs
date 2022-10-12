using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    public bool isinvisible;
    public GameObject footsp;
    CharacterController controller;
    private float timeFootStep;

    private void Awake() {
        controller = GetComponent<CharacterController>();
    }

    private void Update() {
        if(isinvisible) {
            if(Time.time >= timeFootStep) {
                GameObject f = Instantiate(footsp, transform.position, transform.rotation);
                Destroy(f, 3f);
                timeFootStep = Time.time + 0.2f;
            }
        }
    }

    public bool Invisible() {
        return isinvisible =  true;   
    }

    
}
