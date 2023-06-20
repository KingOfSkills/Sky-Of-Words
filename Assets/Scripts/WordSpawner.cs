using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    [SerializeField] private GameObject worldCanvas;

    public WordDisplay SpawnWord()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-2f, 2f), 5.25f);

        GameObject wordObject = Instantiate(wordPrefab, spawnPosition, Quaternion.identity, worldCanvas.transform);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
