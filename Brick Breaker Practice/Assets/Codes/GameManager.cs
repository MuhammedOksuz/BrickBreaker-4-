using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    int scor;

    public Text scorText;
    public Text livesText;
    public bool gameOver;

    [SerializeField] GameObject gameOverPanel;

    private void Start()
    {
        scorText.text = "Scor : " + scor;
        livesText.text = " Live : " + lives;

        gameOverPanel.GetComponent<RectTransform>().localScale = Vector3.zero;
        gameOverPanel.GetComponent<CanvasGroup>().alpha = 0;
    }
    public void Lives(int countLives)
    {
        lives += countLives;
        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }
        livesText.text = "Live : " + lives;
    }
    public void Scor(int countScor)
    {
        scor += countScor;
        scorText.text = "Scor : " + scor;

    }
     void GameOver()
    {
        gameOver = true;
        gameOverPanel.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        gameOverPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void RePlay ()
    {
        SceneManager.LoadScene("1");
    }
    public void Out ()
    {
        Application.Quit();
    }
}
