using System;
using System.IO;
using UnityEngine;

public class LoadScores : MonoBehaviour
{
    public static string path = Path.Combine(Application.streamingAssetsPath, "scores.txt");

    private int num_scores = 5;

    public void AddNewScore()
    {
        string line;
        string[] fields;
        int scores_written = 0;
        string newName = GameManager.PlayerName;
        string newScore = GameManager.Score.ToString();
        bool newScoreWritten = false;
        string[] writeNames = new string[5];
        string[] writeScores = new string[5];

        //newName = NewName.text;
        //newScore = NewScore.text;
        if (GameManager.PlayerName == "")
        {
            GameManager.PlayerName = "Player";
        }

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            if (!newScoreWritten && scores_written < num_scores) // if new score has not been written yet
            {
                //check if we need to write new higher score first
                if (Convert.ToInt32(newScore) > Convert.ToInt32(fields[1]))
                {
                    writeNames[scores_written] = newName;
                    writeScores[scores_written] = newScore;
                    newScoreWritten = true;
                    scores_written++;
                }

            }
            if (scores_written < num_scores) // we have not written enough lines yet
            {
                writeNames[scores_written] = fields[0];
                writeScores[scores_written] = fields[1];
                scores_written++;
            }
        }
        reader.Close();

        //if(File.Exists(scoreFilePath))
        //{

        //}

        // now we have parallel arrays with names and scores to write
        StreamWriter writer = new StreamWriter(path);

        for (int x = 0; x < scores_written; x++)
        {
            writer.WriteLine(writeNames[x] + ',' + writeScores[x]);
        }
        writer.Close();

        //AssetDatabase.ImportAsset(path);
        //TextAsset asset = (TextAsset)Resources.Load("scores");
    }
}
