using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Qutting game...");
    }

    public void StartGame()
    {
        if (PlayerPrefs.GetInt ("lastLevel") > 5)
        {
            PlayerPrefs.SetInt ("lastLevel", 1);
        }

        if (PlayerPrefs.GetInt ("lastLevel") != null && (PlayerPrefs.GetInt ("lastLevel") != 0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + PlayerPrefs.GetInt ("lastLevel"));
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
