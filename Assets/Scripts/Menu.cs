using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private string sceneName = "Main";

    [Header("References")]
    [SerializeField]
    private Button startButton;

    [SerializeField]
    private CanvasGroup mainScreen, settingsScreen, creditsScreen;




    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ToggleCredits(bool enabled)
    {
        mainScreen.gameObject.SetActive(!enabled);
        creditsScreen.gameObject.SetActive(enabled);
    }
    public void ToggleSettings(bool enabled)
    {
        mainScreen.gameObject.SetActive(!enabled);
        settingsScreen.gameObject.SetActive(enabled);
    }
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
    private void Awake()
    {
        if(startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

}
