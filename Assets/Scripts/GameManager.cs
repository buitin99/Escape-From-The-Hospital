using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public bool _isGameHashGameOver;
    public static bool flag;
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
                    if (_instance == null)
                    {
                        GameObject gameManager = new GameObject("GameManager");
                        _instance = gameManager.AddComponent<GameManager>();

                        DontDestroyOnLoad(gameManager);
                    }
            }
            return _instance;
        }
    }

    private void Awake() {;
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // private void Start() {
    //     if (!flag)
    //     {
    //         PauseMenu.FindObjectOfType<AudioSource>().Stop();
    //     }
    // }

    public void GameOverDisplay()
    {
        StartCoroutine(GameOver());
    }

    private IEnumerator GameOver()
    { 
        if (!_isGameHashGameOver)
        {
            _isGameHashGameOver = true;
            yield return new WaitForSeconds(0.1f);
            SceneManager.LoadScene(ScenesManager.scenesLoad[5]);
        }  
    }

    public void CompleteLevelDisplay()
    {
        StartCoroutine(CompleteLevel());
    }

    private IEnumerator CompleteLevel()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(ScenesManager.scenesLoad[4]);
    }

    public string SceneTransitionLevel(int id)
    {
        return ScenesManager.scenesLoad[LoadScene.id+StartSceneController.idScene];
    }

}
