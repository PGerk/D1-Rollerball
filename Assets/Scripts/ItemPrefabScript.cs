using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrefabScript : MonoBehaviour
{
    //public AudioClip collectSound;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        Destroy(gameObject, 3f);
    }
}

