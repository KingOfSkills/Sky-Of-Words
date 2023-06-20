using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestList : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(WordGenerator.GetRandomWord());
        }
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    Debug.Log(WordGenerator.GetWord2());
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    Debug.Log(WordGenerator.GetWord3());
        //}
    }
}
