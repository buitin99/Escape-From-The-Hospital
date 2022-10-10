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

    // private static LoadScene instance = null;
    //  //A public static means of getting the reference to the single created instance, creating one if necessary
    // public static LoadScene Instance
    //     {
    //         get
    //         {
    //             if (instance == null)
    //             {
    //                 // Find singleton of this type in the scene
    //                 var instance = GameObject.FindObjectOfType<LoadScene>();

    //                 // If there is no singleton object in the scene, we have to add one
    //                 if (instance == null)
    //                 {
    //                     GameObject obj = new GameObject("Unity Singleton");
    //                     instance = obj.AddComponent<LoadScene>();

    //                     // The singleton object shouldn't be destroyed when we switch between scenes
    //                     DontDestroyOnLoad(obj);
    //                 }
    //             }

    //             return instance;
    //         }
    //     }

    //      void Awake()
    //     {
    //         if (instance == null)
    //         {
    //             instance = this;

    //             // The singleton object shouldn't be destroyed when we switch between scenes
    //             DontDestroyOnLoad(this.gameObject);
    //         }
    //         // because we inherit from MonoBehaviour whem might have accidentally added several of them to the scene,
    //         // which will cause trouble, so we have to make sure we have just one!
    //         else
    //         {
    //             Destroy(gameObject);
    //         }
    //     }


 
    public void SceneCurrent()
    {
      SceneManager.LoadScene(GameManager.Instance.SceneTransitionLevel());
      PlayerPrefs.SetInt("SelectedLevel",id);
    }
    public void SceneTransition(){
          id++;	    
          StartCoroutine(LoadingSceneAsync(GameManager.Instance.SceneTransitionLevel()));
          PlayerPrefs.SetInt("SelectedLevel",id);
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
