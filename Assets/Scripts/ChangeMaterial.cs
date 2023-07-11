using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    public void Change()
    {
        GameObject button = EventSystem.current.currentSelectedGameObject;

        gameObject.GetComponent<MeshRenderer>().material = button.GetComponent<Image>().material;
    }
}
