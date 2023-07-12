using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject target;

    public float xOffset, yOffset, zOffset;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        //transform.position = target.transform.position + new Vector3(xOffset, 0f, zOffset);
        //transform.LookAt(target.transform.position);
    }
}
