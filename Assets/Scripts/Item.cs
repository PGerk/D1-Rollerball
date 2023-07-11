using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    TextHandling textHandling;
    private void Awake()
    {
        textHandling = FindObjectOfType<TextHandling>();
    }
    private void OnTriggerEnter()
    {
        textHandling.AddPoint();
        Destroy(gameObject);
    }
}
