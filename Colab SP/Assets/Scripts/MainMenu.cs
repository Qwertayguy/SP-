using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Game;

    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Play()
    {
        SceneManager.LoadScene(Game);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
