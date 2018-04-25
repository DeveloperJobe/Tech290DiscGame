using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStartScript : MonoBehaviour
{

    public static bool GameIsPaused;
    public GameObject LevelStartCanvas;


    private void Start()
    {
        Time.timeScale = 0f;
        LevelStartCanvas.SetActive(true);
        GameIsPaused = true;
    }

    public void StartClick()
    {
        Time.timeScale = 1f;
        LevelStartCanvas.SetActive(false);
        GameIsPaused = false;
    }

}