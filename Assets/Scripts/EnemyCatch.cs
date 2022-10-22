using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class EnemyCatch : MonoBehaviour
{
    private Rig _rig;
    private float targetWeight;

    private void Awake() {
        _rig = GetComponent<Rig>();
    }

    void LateUpdate()
    {
        if (true)
        {

            _rig.weight = Mathf.Lerp(_rig.weight, targetWeight, Time.deltaTime*1f);

            targetWeight = 1f;

        }
        
    }
}
