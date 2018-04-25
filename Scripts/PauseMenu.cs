using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused;
    public GameObject pauseMenu;
    public GameObject QuitObject;

    private void Start()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }



    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        QuitObject.SetActive(true);
    }

    public void DontQuit()
    {
        QuitObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
