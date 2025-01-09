using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Manager : MonoBehaviour
{
    public int score = 0;
    public int highScore;
    public static int lastScore = 0;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
        StartCoroutine(Reload());

        highScore = PlayerPrefs.GetInt("high_score", 0);
        Debug.Log("High Score Stored: " + PlayerPrefs.GetInt("high_score", highScore));
        Debug.Log("High Score Get: " + highScore);

        Debug.Log("Last Score: " + lastScore);  
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("high_score", highScore);
            Debug.Log("High Score: " + highScore);
        }
    }

    IEnumerator Score()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.8f);
            score = score + 1;
            Debug.Log("Score: " + score);
            lastScore = score;
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(Random.Range(5, 10));
        SceneManager.LoadScene("Game");
    }
}
