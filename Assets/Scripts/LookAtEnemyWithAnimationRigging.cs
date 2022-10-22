using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class LookAtEnemyWithAnimationRigging : MonoBehaviour
{
    private Rig _rig;
    private float targetWeight;

    private void Awake() {
        _rig = GetComponent<Rig>();
    }


    // private void Update() {
    //     _rig.weight = Mathf.Lerp(_rig.weight, targetWeight, Time.deltaTime*10f);

    //     targetWeight = 1f;
    // }


}
