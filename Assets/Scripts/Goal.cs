using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool active = false;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Movement component = other.gameObject.GetComponent<Movement>();
            if (component != null)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Debug.Log("Goal!");
            }
        }
        else
        {
            Debug.Log("Inactive!");
        }
    }

    public void ActivateGoal()
    {
        active = true;
    }
}
