using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeCounter : MonoBehaviour
{
    TextMeshProUGUI text;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = time.ToString("F2");
    }
}
