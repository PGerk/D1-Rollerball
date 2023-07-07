using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    int points = 0;

    public void AddPoint()
    {
        points++;
        Debug.Log("Point Collected! Current Points: " + points);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
