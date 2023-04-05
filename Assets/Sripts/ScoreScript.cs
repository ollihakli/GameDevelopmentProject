using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    private float timer = 0;
    private int scoreRate = 1;
    public Text highScoreText;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < scoreRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            score++;
            scoreText.text = score.ToString();
            timer = 0;
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                highScore = score;
                highScoreText.text = highScore.ToString();
                PlayerPrefs.SetInt("HighScore", highScore);
            }
            
        }
    }
}
