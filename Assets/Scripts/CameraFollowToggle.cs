using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class CameraFollowToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var active = PlayerPrefs.GetInt(CameraController.FOLLOWS_Y_PREF, 0) != 0;
        var toggle = GetComponent<Toggle>();
        toggle.isOn = active;
        toggle.onValueChanged.AddListener((newActive) => {
            active = newActive;
            PlayerPrefs.SetInt(CameraController.FOLLOWS_Y_PREF, active ? 1 : 0);
        });
    }
}
