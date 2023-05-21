using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverText;
    public GameObject restart;
    public GameObject bird;
    public TextMeshProUGUI HighestScore;
    public GameObject HighScoreText;

    [SerializeField] private int highScore = 0;
    private string highScoreText = "HighScore";

    void Update()
    {
        if (bird.transform.position.y > 25 || bird.transform.position.y < -25)
        {
            gameOver();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverText.SetActive(true);
        restart.SetActive(true);
        HighScoreText.SetActive(true);
        if (playerScore > highScore)
        {
            PlayerPrefs.SetInt(highScoreText, playerScore);
            PlayerPrefs.Save();
        }
        HighestScore.text = "Highest: " + PlayerPrefs.GetInt(highScoreText, 0).ToString();
    }
}
