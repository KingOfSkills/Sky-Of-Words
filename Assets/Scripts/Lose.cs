using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public void LoseGame()
    {
        Debug.Log("You Lose");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
    }
}
