using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSputtering : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lightComponent.intensity = Mathf.PingPong(Time.time, 8);
    }
}
