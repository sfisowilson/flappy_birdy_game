using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicManagerScript : MonoBehaviour
{
    public Text ScoreText;
    private int PlayerScore = 0;
    public int MaxPlayerScore = 100;
    public GameObject GameOverScreen;

    [ContextMenu("increase score")]
    public void AddScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }


    public void RestartGame()
    {
        GameOverScreen.SetActive(false);
        PlayerScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

}
