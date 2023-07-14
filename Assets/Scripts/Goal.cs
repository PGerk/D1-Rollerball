using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool active = false;
    TextHandling text;
    private void Awake()
    {
        text = FindObjectOfType<TextHandling>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Movement component = other.gameObject.GetComponent<Movement>();
            if (component != null)
            {
                //Debug.Log("Goal!");
                if (text.curTime < text.bestTime)
                {
                    string levelString = "Level" + SceneManager.GetActiveScene().buildIndex;
                    PlayerPrefs.SetFloat(levelString, text.curTime);
                }

                //TODO: Load Main Menu
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene(1);

            }
        }
        else
        {
            //Debug.Log("Inactive!");
        }
    }

    public void ActivateGoal()
    {
        active = true;
    }
}
