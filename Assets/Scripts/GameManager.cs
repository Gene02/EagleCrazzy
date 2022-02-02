using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highscoreText;

    public bool isGameOver;
    private int score;
    private int highscore;
    private int GameOver;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
       if(Input.GetMouseButtonDown(0) && isGameOver)
        {
            SceneManager.LoadScene("MenuGameOver");
            RestartGame();
        } 
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("MenuGameOver");
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        highscore = (int)score;
        scoreText.text = highscore.ToString();
        GameOverText.text = GameOver.ToString();


        if(PlayerPrefs.GetInt("score")<=highscore)
        PlayerPrefs.SetInt("score", highscore);
        highscoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void highscorefun()
    {
        highscoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
}
