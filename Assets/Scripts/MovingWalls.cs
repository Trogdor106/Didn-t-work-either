using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    float speed = 1.0f;
    float totalTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0); //Move object 1.5 units per second
        totalTime += Time.deltaTime;

        if (totalTime >= 4.5f) //If the object has moved for 5 seconds, reverse it.
        {
            speed *= -1.0f;
            totalTime = 0.0f;
        }
    }
}
