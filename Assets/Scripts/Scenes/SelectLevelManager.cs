using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelManager : MonoBehaviour
{
    public Button[] buttonList;

    public GameObject[] lockList; 

    private PlayerData playerData;

    private void Awake() 
    {
        playerData = PlayerData.Load();
    }

    private void Start() 
    {
        // for (int i = 0; i < buttonList.Length; i++)
        // {
        //     buttonList[i].interactable = false;
        //     for(int j = 0; j <= PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS); j++)
        //     {
        //         lockList[j].SetActive(false);
        //         buttonList[j].interactable = true;
        //     }
        // }

        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].interactable = false;
            for(int j = StartSceneController.idScene; j <= playerData.totalLevel; j++)
            {
                lockList[j-StartSceneController.idScene].SetActive(false);
                buttonList[j-StartSceneController.idScene].interactable = true;
            }
        }
        
    }

    public void ChangeLevel(int id)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            SceneManager.LoadScene(ScenesManager.scenesLoad[id]+StartSceneController.idScene);
        }
    }
}
