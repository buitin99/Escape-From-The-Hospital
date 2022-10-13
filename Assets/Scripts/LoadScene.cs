using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public static int id;

    public GameObject loadingScreen;
    public Image loadingBarFill;
 
    public void SceneCurrent()
    {
      SceneManager.LoadScene(GameManager.Instance.SceneTransitionLevel());
      GameManager.Instance._isGameHashGameOver = false;
      if (id != 0)
      {
        id--;
        PlayerPrefs.SetInt(PrefConst.CHANGED_LEVELS,id);
      }
    }
    public void SceneTransition(){
          id++;	    
          StartCoroutine(LoadingSceneAsync(GameManager.Instance.SceneTransitionLevel()));
          PlayerPrefs.SetInt(PrefConst.CHANGED_LEVELS,id);
    }

    IEnumerator LoadingSceneAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress/1f);

            loadingBarFill.fillAmount = progressValue;

            yield return null;

        }
    }

    public void SceneShop()
    {
        SceneManager.LoadScene("Scenes/ShopGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scenes/StartScene");
    }


}
