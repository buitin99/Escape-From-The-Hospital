using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InvisibleBar : MonoBehaviour
{
    private Camera _cam;
    [SerializeField]
    private Image _invisibleBarSpite;
    
    private void Start() 
    {
        _cam = Camera.main;
    }

    private void Update() 
    {
        transform.rotation = Quaternion.LookRotation(transform.position - _cam.transform.position);        
    }
    public void UpdateInvisibleBar(float currentInvisible, float maxInvisible)
    {
        _invisibleBarSpite.fillAmount = currentInvisible/maxInvisible;
    }

    
}
