using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    float speed = 1.5f;
    float totalTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime); //Move object 1.5 units per second
        totalTime += Time.deltaTime;

        if (totalTime >= 5.0f)
        {
            speed *= -1.0f;
            totalTime = 0.0f;
        }
    }
}
