using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlayer : MonoBehaviour
{

    private GameObject[] _bodyCharacters;
    // private GameObject _shoes;
    public static bool isInvisible;
    // Start is called before the first frame update
    void Start()
    {
        _bodyCharacters = GameObject.FindGameObjectsWithTag("Invisible");
        // _shoes = GameObject.FindGameObjectWithTag("Shoes");
        // _shoes.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerPowerUp>().Invisible();
        }
    } 
}
