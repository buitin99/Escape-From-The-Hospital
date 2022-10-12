using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlayer : MonoBehaviour
{

    private GameObject[] _bodyCharacters;
    public static bool isInvisible;
    // Start is called before the first frame update
    void Start()
    {
        _bodyCharacters = GameObject.FindGameObjectsWithTag("Invisible");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Potion"))
        {
            // other.GetComponent<PlayerPowerUp>().Invisible();
            FindObjectOfType<PlayerPowerUp>().Invisible();

            foreach(GameObject b in _bodyCharacters)
            {
                b.SetActive(false);
            }
        }
    } 
}
