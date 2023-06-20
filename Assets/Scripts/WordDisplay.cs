using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    private float fallSpeed = .75f;
    public WordManager wordManager;
    private GameManager gameManager;
    //private WordDeleter wordDeleter;
    //private Audio audio1;

    private void Awake()
    {
        //wordDeleter = FindObjectOfType<WordDeleter>();
        wordManager = FindObjectOfType<WordManager>();
        //audio1 = FindObjectOfType<Audio>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        Fall();
        //Debug.Log(transform.position.y);\
    }
    private void Fall()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        if (transform.position.y <= -5)
        {
            //Debug.Log("Text left " + text.text);
            wordManager.RemoveWord(text.text);
            DestroyWordGameObject();
            //gameManager.Lose();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.TryGetComponent(out Lose lose))
        //{
        //    lose.LoseGame();
        //    Debug.Log("Lose");
        //}
        //if(collision.GetComponent<Lose>() != null)
        //{
        //    Debug.Log("Lose");
        //}
    }
    public void SetWord(string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        // Remove Typed Letters
        if (text != null)
        {
            GameManager.LettersTypedCorrectly++;
            text.text = text.text.Remove(0, 1);
            text.color = Color.red;
            //audio1.PlayType();
        }
    }
    public void DestroyWordGameObject()
    {
        Destroy(gameObject);
    }
}
