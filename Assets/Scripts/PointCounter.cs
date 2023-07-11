using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{

    int points = 0;
    TextMeshProUGUI pointCount;

    public void AddPoint()
    {
        points++;
        pointCount.text = points.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        pointCount = GameObject.FindGameObjectWithTag("ItemsFound").gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        pointCount.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
