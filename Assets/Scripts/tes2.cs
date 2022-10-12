using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes2 : MonoBehaviour
{
    // private int id;
    // public Material material;
    private CharacterController characterController;
    private GameObject[] respawns;

    private GameObject shoes;




    // Start is called before the first frame update
    void Start()
    {
        // id = PlayerPrefs.GetInt("SelectedCharacters", 0);
        // Debug.Log(id);

        characterController = FindObjectOfType<CharacterController>();
        respawns = GameObject.FindGameObjectsWithTag("Invisible");
        shoes = GameObject.FindGameObjectWithTag("Shoes");
        shoes.SetActive(false);
        // GameObject player = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(characterController);
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("ABC");
            characterController.gameObject.layer = LayerMask.NameToLayer("Default");
            // Debug.Log(characterController.gameObject.layer);
            foreach(GameObject respawn in respawns)
            {
                respawn.SetActive(false);
            }
        }    
    }

    private void OnTriggerEnter(Collider other) {
         if (other.CompareTag("Player"))
        {
            // Debug.Log("ABC");
            characterController.gameObject.layer = LayerMask.NameToLayer("Default");
            // Debug.Log(characterController.gameObject.layer);
            foreach(GameObject respawn in respawns)
            {
                respawn.SetActive(false);
                shoes.SetActive(true);
            }
        }
    } 
}
