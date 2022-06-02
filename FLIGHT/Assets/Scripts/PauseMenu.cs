using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject PauseUI;

    void Start()
    {
        PauseUI = transform.GetChild(0).gameObject;

        PlayerPrefs.SetInt ("lastLevel", SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
