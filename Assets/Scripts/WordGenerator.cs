using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private TextAsset wordListTxt;
    public static string[] wordArray = new string[1000];// = { "word1", "word2", "word3" };

    private void Awake()
    {
        //StreamReader reader = new StreamReader("Assets/Resources/WordList.txt");
        //int i = 0;
        //while (!reader.EndOfStream && i < wordArray.Length)// && scores_read < num_scores)
        //{
        //    //Debug.Log(i);
        //    //Debug.Log(reader.ReadLine());
        //    wordArray[i] = reader.ReadLine();
        //    i++;
        //}

        //Debug.Log(wordList[0]);
        //Debug.Log(reader.ReadLine());
        //Debug.Log("Word 0 : " + wordList[0] + "\nWord 1 : " + wordList[1]);

        LoadWordListUsingStreamingAssets();
    }
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordArray.Length);
        string randomWord = wordArray[randomIndex];
        return randomWord;
    }
    private void LoadWordListUsingStreamingAssets()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, "WordList.txt"); // Update with the correct file name

        if (File.Exists(filePath))
        {
            wordArray = File.ReadAllLines(filePath);
            Debug.Log("File DOES exists!");
            // Do something with the loaded words array
            // Example: print the words
            //foreach (string word in wordArray)
            //{
            //    Debug.Log(word);
            //}
        }
        else
        {
            Debug.Log("File DOES NOT exists!");
        }
    }
    //private void LoadWordListUsingResourcesFolder()
    //{
    //    string filePath = "Assets/Resources/WordList.txt";
    //    wordListTxt = Resources.Load<TextAsset>(filePath);

    //    if (wordListTxt != null)
    //    {
    //        Debug.Log("TextAsset is not null");
    //        wordArray = wordListTxt.text.Split('\n');

    //        // Do something with the loaded words array
    //        // Example: print the words
    //        foreach (string word in wordArray)
    //        {
    //            Debug.Log(word);
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("TextAsset is null");
    //    }
    //}
    //public static string GetWord1()
    //{
    //    return wordList[0];
    //}
    //public static string GetWord2()
    //{
    //    return wordList[1];
    //}
    //public static string GetWord3()
    //{
    //    return wordList[2];
    //}
}
