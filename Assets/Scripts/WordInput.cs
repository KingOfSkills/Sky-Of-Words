using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    private WordManager wordManager;

    private void Start()
    {
        wordManager = FindObjectOfType<WordManager>();
    }
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            GameManager.LettersTyped++;
            //Debug.Log(letter);
            wordManager.TypeLetter(letter);
        }
    }
}
