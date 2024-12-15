using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false; // Czy gra jest wstrzymana
    public GameObject pauseMenuUI;      // Panel pauzy

    void Update()
    {
        // Sprawdzenie, czy gracz nacisn¹³ klawisz pauzy (domyœlnie Esc)
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
        pauseMenuUI.SetActive(false);      // Ukryj menu pauzy
        Time.timeScale = 1f;               // Wznów czas gry
        isPaused = false;                  // Ustaw flaga pauzy na false
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);       // Poka¿ menu pauzy
        Time.timeScale = 0f;               // Zatrzymaj czas gry
        isPaused = true;                   // Ustaw flaga pauzy na true
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;               // Przywróæ normalny czas gry
        SceneManager.LoadScene("MainMenu"); // Za³aduj g³ówne menu (upewnij siê, ¿e scena istnieje)
    }

    public void QuitGame()
    {
        Debug.Log("Gra zakoñczona!");      // Informacja w edytorze
        Application.Quit();                // Zamkniêcie gry w wersji build
    }
}
