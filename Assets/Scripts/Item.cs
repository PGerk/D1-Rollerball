using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    TextHandling textHandling;
    public GameObject itemParticlePrefab;
    private void Awake()
    {
        textHandling = FindObjectOfType<TextHandling>();
    }
    private void OnTriggerEnter()
    {
        Instantiate(itemParticlePrefab, transform.position, Quaternion.identity);
        textHandling.AddPoint();
        Destroy(gameObject);
    }
}
