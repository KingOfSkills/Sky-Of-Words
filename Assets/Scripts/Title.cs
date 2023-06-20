using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    private float fallSpeed;

    void Start()
    {
        fallSpeed = Random.Range(90f, 110f);
    }
    void Update()
    {
        Fall();
    }
    private void Fall()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        if (transform.position.y <= 0f)
        {
            // Move to Top of Screen
            transform.position = new Vector3(transform.position.x, 1000f, transform.position.z);
            fallSpeed = Random.Range(75f, 125f);
        }
    }
}
