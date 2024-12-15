using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
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
