using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelManager : MonoBehaviour
{
    public Button[] buttonList;

    private void Start() 
    {
        
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].interactable = false;
            for(int j = 0; j <= PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS); j++)
            {
                buttonList[j].interactable = true;
            }
        }
    }

    public void ChangeLevel(int id)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            SceneManager.LoadScene(Manager.levelList[id]);
        }
    }
}
