using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private AudioSource _audioSrc;
    public GameObject pausePanel;

    public GameObject buttonMute;
    public GameObject buttonUnMute;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        _audioSrc = FindObjectOfType<AudioSource>();
        pausePanel.SetActive(false);
        buttonUnMute.SetActive(false);
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Mute()
    {
        _audioSrc.Stop();
        buttonMute.SetActive(false);
        buttonUnMute.SetActive(true);
        pauseMenu.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UnMute()
    {
        _audioSrc.Play();
        buttonMute.SetActive(true);
        buttonUnMute.SetActive(false);
        pauseMenu.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;        
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[0]);
    }


}
