using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // This makes it the variable private but the also shows up in the editor
    [SerializeField] GameObject pauseMenu;
    // Calling whenever the pause button is pressed
    public void Pause()
    {
        // Enabling the pause menu when the user clicks on the pause button
        pauseMenu.SetActive(true);
        // This makees the game freeze when the puase button is presssed
        Time.timeScale = 0f;
    }

    // calling whenever the Resume button is pressed
    public void Resume()
    {
        // Makes the pause menu disabled when the user clicks on the resume button
        pauseMenu.SetActive(false);
        // The game unfreezes when resume button is pressed
        Time.timeScale = 1f;
    }
    
    // calling whenever the Home button is pressed
    public void Home(int SceneID)
    {
        // The game unfreezes when the home button is pressed
        Time.timeScale = 1f;
        // loads the main menu scene when the home button is pressed
        SceneManager.LoadScene(SceneID);
    }
}