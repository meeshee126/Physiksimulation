using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// Starts game
    /// </summary>
    public void ButtonStartGame()
    {
        SceneManager.LoadScene("Simulation");
    }

    /// <summary>
    /// Quit Game
    /// </summary>
    public void ButtonQuitGame()
    {
        Application.Quit();
    }
}
