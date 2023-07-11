using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextHandling : MonoBehaviour
{
    public TextMeshProUGUI[] texts;
    public float curTime, bestTime;
    int points = 0;
    int itemAmount;

    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponentsInChildren<TextMeshProUGUI>();

        curTime = 0f;
        
        //Fid best time, set time text
        string levelString = "Level" + SceneManager.GetActiveScene().buildIndex;
        bestTime = PlayerPrefs.GetFloat(levelString, 0f);
        string bestTimeString;
        if (bestTime > 0)
        {
            bestTimeString = bestTime.ToString("F2");
        }
        else
        {
            bestTimeString = "None";
        }
        texts[7].text = bestTimeString;

        //Set points text
        texts[1].text = points.ToString();

        //Find Item amount, set text
        itemAmount = GameObject.FindGameObjectsWithTag("Item").Length;
        texts[3].text = itemAmount.ToString();
    }

    public void AddPoint()
    {
        points++;
        texts[0].text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        texts[8].text = curTime.ToString("F2");
    }
}
