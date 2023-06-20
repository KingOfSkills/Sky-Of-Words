using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text time;

    private void Start()
    {
        scoreText.text = GameManager.Score.ToString();
        if (GameManager.Score == 0)
        {
            scoreText.text = "000";
        }
    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
    public void UpdateTime(float new_time)
    {
        time.text = new_time.ToString("F2");
    }
}
