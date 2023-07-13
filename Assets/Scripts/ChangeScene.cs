using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SwitchTo(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
