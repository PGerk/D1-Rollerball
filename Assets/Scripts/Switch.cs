using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public BoxCollider tbd;

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(tbd);
        target.SetActive(!target.activeSelf);
        transform.position -= new Vector3(0f, 0.1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
