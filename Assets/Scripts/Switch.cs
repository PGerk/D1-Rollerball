using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    BoxCollider tbd;
    AudioSource audioSource;

    public GameObject target;
    // Start is called before the first frame update
    void Awake()
    {
        tbd = GetComponent<BoxCollider>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(tbd);
        if (target != null)
        {
            target.SetActive(!target.activeSelf);
        }
        audioSource.Play();
        transform.position -= new Vector3(0f, 0.1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
