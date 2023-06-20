using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;

    public WordDisplay display;

    public Word(string initWord, WordDisplay initDisplay)
    {
        word = initWord;
        typeIndex = 0;
        display = initDisplay;
        display.SetWord(word);
    }
    public char GetNextLetter()
    {
        return word[typeIndex];
    }
    public void TypeLetter()
    {
        typeIndex++;
        // Remove Letter on Screen
        display.RemoveLetter();
    }
    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            // Remove word from screen
            display.DestroyWordGameObject();
        }
        return wordTyped;
    }
}
