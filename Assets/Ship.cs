using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    void Update()
    {
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;

        // Debugging output
        Debug.Log(Input.mousePosition);
        Debug.Log("World point: " + worldPoint);
    } 
}
