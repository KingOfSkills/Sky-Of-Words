using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private InputField playerName;
    //[SerializeField] private HighScores highScores;

    private void Start()
    {
        GameManager.Score = 0;
        GameManager.LettersTyped = 0;
        GameManager.LettersTypedCorrectly = 0;
        playerName.text = GameManager.PlayerName;
        //highScores.DisplayScores();
    }
    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
    public void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void UpdateName()
    {
        GameManager.PlayerName = playerName.text;
    }
}
