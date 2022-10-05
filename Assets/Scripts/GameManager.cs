using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public bool _isGameHashGameOver;

    public int _id;
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
            // DontDestroyOnLoad(this.gameObject);
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
                SceneManager.LoadScene("GameOverScene");
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
    public void Restart()
    {
        SceneManager.LoadScene(_id);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(_id+1);
    }
}
