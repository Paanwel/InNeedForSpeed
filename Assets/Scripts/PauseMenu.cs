﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //przy małych projektach zmienna statyczna jest okej, przy dużych to jest szybka droga do spagetti code. Nie nadużywaj zmiennych statycznych w tym singletonów
    public static bool isPaused = false; 
    public GameObject pauseMenuUI;      

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        pauseMenuUI.SetActive(false);      
        Time.timeScale = 1;             
        isPaused = false;                  
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);       
        Time.timeScale = 0;             
        isPaused = true;                  
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;               
        SceneManager.LoadScene("MenuGlowne"); 
    }

    public void QuitGame()
    {
        Debug.Log("Gra zakoñczona!");      
        Application.Quit();                
    }
}
