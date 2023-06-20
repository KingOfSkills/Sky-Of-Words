using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score = 0;
    public static string PlayerName;
    public UI uiObject;
    //public static int lives = 2000;
    public float timeToPlay = 60;

    public static int LettersTyped;
    public static int LettersTypedCorrectly;

    private void Start()
    {
        timeToPlay = 60f;
    }
    private void Update()
    {
        CountDown();
    }
    public void AddScore(int amount)
    {
        Score += amount;
        uiObject.UpdateScore(Score);
    }
    //public void Lose()
    //{
    //    lives -= 1;
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    if (lives <= 0)
    //    {
    //        SceneManager.LoadScene("Credits");
    //    }    
    //}
    public void CountDown()
    {
        timeToPlay -= Time.deltaTime;
        uiObject.UpdateTime(timeToPlay);
        if (timeToPlay <= 0)
        {
            SceneManager.LoadScene("Credits");
        }
    }
    public void AddTime()
    {
        timeToPlay += 5f;
    }
    public void MinusTime(int amount)
    {
        timeToPlay -= amount;
    }
}
