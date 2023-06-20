using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ReadScores : MonoBehaviour
{
    public Text HighScoresText;
    public int num_scores = 5;

    private void Start()
    {
        //string filePath = "Assets/Resources/scores.txt";
        //TextAsset textAsset = Resources.Load<TextAsset>(filePath);

        //if (textAsset != null)
        //{
        //    string[] words = textAsset.text.Split('\n');

        //    // Do something with the loaded words array
        //    // Example: print the words
        //    foreach (string word in words)
        //    {
        //        Debug.Log(word);
        //    }
        //}

        ShowTopScores();
    }
    public void ShowTopScores()
    {
        string path = LoadScores.path;
        string line;
        string[] fields;
        string[] playerNames = new string[num_scores];
        int[] playerScores = new int[num_scores];
        int scores_read = 0;

        HighScoresText.text = ""; // clear the scores box

        StreamReader reader = new StreamReader(path);
        if (reader == null)
        {
            Debug.Log("No File");
        }
        while(!reader.EndOfStream && scores_read < num_scores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScoresText.text += fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }
    }
}
