using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    private int scoreIndex = 1;
    public GameObject gamerest;
    Controller controller;

    private void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        scoreIndex = controller.score_multiplier;
    }

    [ContextMenu("INCREASE SCORE")]
    public void AddScore()
    {
        playerScore += scoreIndex;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver()
    {
        gamerest.SetActive(true);
    }
}
