using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public bool _isGameHashGameOver;
    private static GameManager _instance = null;

    public GameObject completeLevel;
    public GameOverScrene gameOverScrene;

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

    private void Awake() {
        if (_instance == null)
        {
            _instance = this;
            // DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void GameOver()
    {
            if (!_isGameHashGameOver)
            {
                _isGameHashGameOver = true;
                gameOverScrene.Setup();
            }
    }

    public void CompleteLevelEnd()
    {
        StartCoroutine(CompleteLevel());
    }

    private IEnumerator CompleteLevel()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("CompleteScene");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
