using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;

    private float wordDelay = 1.5f;
    private float nextWordTime = 0f;

    private void Update()
    {
        SpawnWord();
    }
    private void SpawnWord()
    {
        if (Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }
}
