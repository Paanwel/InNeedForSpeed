using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource audioSource;
    [SerializeField] private PlayerMovement playerMovement;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && playerMovement.GameOver == false)
        {
            if (isPaused)
            {
                
                Resume();
                audioSource.Play();
            }
            else
            {
                
                Pause();
                audioSource.Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);      
        Time.timeScale = 1;             
        isPaused = false;
        audioSource.Play();
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
    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }


}
