using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject m_uiPauseMenu;

    void Update()
    {
        InGame();
    }

    void InGame()
    {
        // restarts simulation
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Simulation");
        }

        // open or close pause menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }     
    }

    public void PauseGame()
    {
        // checks after pressing "escape" button if pause Menu is active or not

        // if pause Menu is not active
        if (m_uiPauseMenu.activeInHierarchy == false)
        {
            // pause Menu is setting active
            m_uiPauseMenu.gameObject.SetActive(true);

            // disable enviroment physics
            Time.timeScale = 0;

            // disable Ball Controlls
            Ball ball = GameObject.Find("Ball").GetComponent<Ball>();
            ball.enabled = false;
        }

        // if pause menu is active after pressing "escape" button
        else
        {
            // pause menu is setting inactive
            m_uiPauseMenu.gameObject.SetActive(false);

            // enable enviroment physics
            Time.timeScale = 1;

            // enable Ball Controlls
            Ball ball = GameObject.Find("Ball").GetComponent<Ball>();
            ball.enabled = true;
        }
    }
    
    public void ButtonResumeGame()
    {
        PauseGame();
    }

    public void ButtonQuitGame()
    {
        Application.Quit();
    }

}
