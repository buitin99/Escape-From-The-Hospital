using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public static int id;
    public GameObject loadingScreen;
    public Image loadingBarFill;
 
    public void PlayAgain()
    {
      SceneManager.LoadScene(GameManager.Instance.SceneTransitionLevel(id));
      GameManager.Instance._isGameHashGameOver = false;
      if (id != 0)
      {
        PlayerPrefs.SetInt(PrefConst.CURENT_LEVELS,id);
      }
    }
    public void NextLevel()
    {
        id++;	    
        PlayerPrefs.SetInt(PrefConst.CURENT_LEVELS,id);
        PlayerPrefs.SetInt(PrefConst.CHANGED_LEVELS,id);
        StartCoroutine(LoadingSceneAsync(GameManager.Instance.SceneTransitionLevel(id)));
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

    public void GoToShop()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[1]);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[0]);
    }
}
