using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private bool _isGameHashGameOver;

    public GameObject completeLevel;
    public GameOverScrene gameOverScrene;
    public void GameOver()
    {
            if (!_isGameHashGameOver)
            {
                _isGameHashGameOver = true;
                gameOverScrene.Setup();
            }
    }

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
