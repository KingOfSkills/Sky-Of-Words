using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public bool hasActiveWord = false;
    private Word activeWord;
    private int activeWordIndex;

    public WordSpawner wordSpawner;
    private GameManager gameManager;
    private Audio audioScrpit;

    public PauseMenu pauseMenu;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioScrpit = FindObjectOfType<Audio>();
        pauseMenu = FindObjectOfType <PauseMenu>();
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    AddWord();
        //}
    }
    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        //Debug.Log(word.word);
        words.Add(word);
        //Debug.Log(words);
        //foreach(Word iword in words)
        //{
        //    Debug.Log(word.display.text.text);
        //}
        //for (int i = 0; i < words.Count; i++)
        //{
        //    Debug.Log(words[i].display.text.text);
        //}
    }
    public void TypeLetter(char letter)
    {
        if (pauseMenu.isPaused == false)
        {
            if (hasActiveWord)
            {
                // Check is letter was next
                if (activeWord.GetNextLetter() == letter)
                {
                    activeWord.TypeLetter();
                    audioScrpit.PlayType();
                }
                // Remove it from word
            }
            else
            {
                int i = 0;
                foreach (Word word in words)
                {
                    if (word.GetNextLetter() == letter)
                    {
                        activeWord = word;
                        activeWordIndex = i;
                        //Debug.Log("Active Word Index = " + activeWordIndex);
                        //Debug.Log("Active Word = " + activeWord);
                        //gameManager.AddTime();
                        hasActiveWord = true;
                        word.TypeLetter();
                        audioScrpit.PlayType();
                        break;
                    }
                    //Debug.Log("Looping through list " + i);
                    i++;
                }
            }
            if (hasActiveWord && activeWord.WordTyped())
            {
                hasActiveWord = false;
                words.Remove(activeWord);
                // Add to Score
                gameManager.AddScore(100); 
                // Add to Time
                gameManager.AddTime();
                //Debug.Log("Word typed! New Active Word = " + activeWord);
                audioScrpit.PlayComplete();
            }
        }
    }
    public void RemoveWord(string wordStr)
    {
        gameManager.MinusTime(wordStr.Length);
        bool wordRemoved = false;
        for (int i = 0; i < words.Count; i++) // Loop words.count amount of times
        {
            if (hasActiveWord == true && activeWordIndex == i)
            {
                //Debug.Log("Removed Active Word");
                words.Remove(words[activeWordIndex]);
                hasActiveWord = false;
                wordRemoved = true;
            }
            if (wordStr == words[i].word) // Random word that is not active word
            {
                //Debug.Log("Removing word " + words[i].word);
                words.Remove(words[i]);
                //Debug.Log("Words Remaining " + words.Count);
                i--; // Minus 1 to i because we removed one from the list so the list is one less than before
                activeWordIndex--;
                wordRemoved = true;
            }
            if (wordRemoved)
            {
                //Debug.Log("Break fro-loop");
                break;
            }
            //Debug.Log("In for-loop;");
        }
        audioScrpit.PlayFailed();
    }
}
