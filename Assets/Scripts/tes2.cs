using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes2 : MonoBehaviour
{
    private int id;
    // Start is called before the first frame update
    void Start()
    {
        id = PlayerPrefs.GetInt("SelectedCharacters", 0);
        Debug.Log(id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
