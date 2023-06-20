using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    [SerializeField] private Text leaderBoard;
    public static string[] PlayerNames = new string[5];
    public static  int[] Scores = new int[5];

    //private void Start()
    //{
    //    DisplayScores();
    //}
    public void UpdateScores()
    {
        //PlayerPrefs.
        var score = GameManager.Score;
        var name = GameManager.PlayerName;
        for (int i = 0; i < Scores.Length; i++)
        {
            if (score > Scores[i])
            {
                score = Scores[i];
                name = PlayerNames[i];
                Scores[i] = GameManager.Score;
                PlayerNames[i] = GameManager.PlayerName;
            }
        }
    }
    public void DisplayScores()
    {
        leaderBoard.text = 
            PlayerNames[0] + " " + Scores[0] + "\n" +
            PlayerNames[1] + " " + Scores[1] + "\n" +
            PlayerNames[2] + " " + Scores[2] + "\n" +
            PlayerNames[3] + " " + Scores[3] + "\n" +
            PlayerNames[4] + " " + Scores[4] + "\n";
    }
}
