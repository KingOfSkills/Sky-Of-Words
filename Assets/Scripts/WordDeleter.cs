using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDeleter : MonoBehaviour
{
    public WordManager wordManager;

    //private void DeleteWord(string wordStr)
    //{
    //    bool wordRemoved = false;
    //    for (int i = 0; i < wordManager.words.Count; i++) // Loop words.count amount of times
    //    {
    //        if (wordManager.hasActiveWord == true && wordManager.activeWordIndex == i)
    //        {
    //            //Debug.Log("Removed Active Word");
    //            wordManager.words.Remove(wordManager.words[wordManager.activeWordIndex]);
    //            wordManager.hasActiveWord = false;
    //            wordRemoved = true;
    //        }
    //        if (wordStr == wordManager.words[i].word) // Random word that is not active word
    //        {
    //            //Debug.Log("Removing word " + words[i].word);
    //            wordManager.words.Remove(wordManager.words[i]);
    //            //Debug.Log("Words Remaining " + words.Count);
    //            i--; // Minus 1 to i because we removed one from the list so the list is one less than before
    //            wordManager.activeWordIndex--;
    //            wordRemoved = true;
    //        }
    //        if (wordRemoved)
    //        {
    //            Debug.Log("Break fro-loop");
    //            break;
    //        }
    //        Debug.Log("In for-loop;");
    //    }
    //}
}
