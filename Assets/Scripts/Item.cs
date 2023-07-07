using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    PointCounter pointCounter;
    private void Awake()
    {
        pointCounter = FindObjectOfType<PointCounter>();
    }
    private void OnTriggerEnter()
    {
        pointCounter.AddPoint();
        Destroy(gameObject);
    }
}
