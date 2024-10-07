using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject scoreCanvas;
    [SerializeField] private AudioSource backgroundMusic;
    private bool isPaused = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        scoreCanvas.SetActive(false);

        backgroundMusic.Stop();

        gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            backgroundMusic.UnPause();
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            backgroundMusic.Pause();
            Time.timeScale = 0;
            isPaused = true;
        }
    }

}
