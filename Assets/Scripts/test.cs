using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Image abc;
    public Sprite acb ;


    private void Start() {
       abc = FindObjectOfType<Image>();
        abc.sprite = acb;

    }
    private void Update() {
        Debug.Log(acb);
    }

}
