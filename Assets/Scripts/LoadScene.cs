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
    }
    public void SceneTransition(){
          // SceneManager.LoadScene(GameManager.Instance.SceneTransitionLevel());
          id++;	    
          StartCoroutine(LoadingSceneAsync(GameManager.Instance.SceneTransitionLevel()));
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


}
