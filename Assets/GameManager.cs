using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;  
    public GameObject gameOverText;
    public GameObject restartButton;

    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0f; //Stop the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}