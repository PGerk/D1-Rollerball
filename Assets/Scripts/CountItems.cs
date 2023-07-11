using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountItems : MonoBehaviour
{
    int itemAmount;
    public TextMeshProUGUI amountText;
    // Start is called before the first frame update
    void Start()
    {
        itemAmount = GameObject.FindGameObjectsWithTag("Item").Length;
        amountText.text = itemAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
