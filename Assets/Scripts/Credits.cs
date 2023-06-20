using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //[SerializeField] private HighScores highScores;

    public Text playerName;
    public Text score;
    public Text lettersTypedText;
    public Text lettersTypedCorrectlyText;
    public Text percentageCorrect;

    private void Start()
    {
        if (GameManager.PlayerName == null)
        {
            GameManager.PlayerName = "Gamer";
        }
        playerName.text = GameManager.PlayerName;
        score.text = GameManager.Score.ToString();
        var lettersTyped = GameManager.LettersTyped;
        var lettersTypedCorrectly = GameManager.LettersTypedCorrectly;
        lettersTypedText.text = lettersTyped.ToString();
        lettersTypedCorrectlyText.text = lettersTypedCorrectly.ToString();
        if (lettersTyped == 0)
        {
            lettersTyped = 1;
        }
        percentageCorrect.text = (((float)lettersTypedCorrectly / (float)lettersTyped) * 100).ToString("F2") + "%";
        //highScores.UpdateScores();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
