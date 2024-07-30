using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    Vector3 rotation = new Vector3(0, 0, 0);
    float degreesPerSecond = 10.0f;

    // Update is called once per frame
    void Update()
    {
        rotation.x += degreesPerSecond * Time.deltaTime;
        transform.eulerAngles = rotation;
    }
}
