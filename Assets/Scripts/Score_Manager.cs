using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Score_Manager : MonoBehaviour
{
    public int score = 0;
    public int highScore;


    public Text scoreText;
    public Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());

        highScore = PlayerPrefs.GetInt("high_score", 0);
        highScoreText.text = "HighScore: " + highScore.ToString();
        
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
            
        }
    }


}
