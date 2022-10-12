using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private string[] stringLevel = {"Scenes/Level1","Scenes/Level2","Scenes/Level3"};
    public bool _isGameHashGameOver;

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
            SceneManager.LoadScene("LoseScene");
        }  
    }

    public void CompleteLevelDisplay()
    {
        StartCoroutine(CompleteLevel());
    }

    private IEnumerator CompleteLevel()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("CompleteScene");
    }

    public string SceneTransitionLevel()
    {
        return stringLevel[LoadScene.id];
    }

}
