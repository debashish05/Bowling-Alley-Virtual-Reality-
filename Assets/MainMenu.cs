using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public HighScores highScore;
    public Text highScoreValue;
    public Score scores;
    public GameObject highScoreMenu;
    public GameObject lastScoresMenu;
    public Text lastScoresValue1;
    public Text lastScoresValue2;
    public Text lastScoresValue3;
    public Text lastScoresValue4;
    public Text lastScoresValue5;
    public Text lastScoresValue6;
    public Text lastScoresValue7;
    public Text lastScoresValue8;
    public Text lastScoresValue9;
    public Text lastScoresValue10;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenHighScore()
    {
        highScoreMenu.SetActive(true);
        highScoreValue.text = highScore.highScore.ToString();
    }

    public void CloseHighScore()
    {
        highScoreMenu.SetActive(false);
    }

    public void OpenLastScore()
    {
        lastScoresMenu.SetActive(true);
        lastScoresValue1.text = scores.PlayerScore[0].ToString();
        lastScoresValue2.text = scores.PlayerScore[1].ToString();
        lastScoresValue3.text = scores.PlayerScore[2].ToString();
        lastScoresValue4.text = scores.PlayerScore[3].ToString();
        lastScoresValue5.text = scores.PlayerScore[4].ToString();
        lastScoresValue6.text = scores.PlayerScore[5].ToString();
        lastScoresValue7.text = scores.PlayerScore[6].ToString();
        lastScoresValue8.text = scores.PlayerScore[7].ToString();
        lastScoresValue9.text = scores.PlayerScore[8].ToString();
        lastScoresValue10.text = scores.PlayerScore[9].ToString();
    }

    public void CloseLastScore()
    {
        lastScoresMenu.SetActive(false);
    }
        
    public void ResetHighScore()
    {
        highScore.highScore = 0;
        highScoreValue.text = highScore.highScore.ToString();
    }
}
