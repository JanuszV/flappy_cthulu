using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore(int scoretoAdd)
    {
        playerScore += scoretoAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
