using System;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class PlayerMaterial : MonoBehaviour
{
    [SerializeField]
    private Material[] materialChoices;

    private static event Action<int> ChoiceChanged;

    public static void Set(int choice)
    {
        PlayerPrefs.SetInt("player.skin", choice);
        ChoiceChanged?.Invoke(choice);
    }

    void OnEnable() {
        ChoiceChanged += ApplyChoice;
    }

    void OnDisable() {
        ChoiceChanged -= ApplyChoice;
    }

    void Start()
    {
        ApplyChoice(PlayerPrefs.GetInt("player.skin", 0));
    }

    void ApplyChoice(int choice)
    {
        if (choice >= materialChoices.Length) choice = 0;
        gameObject.GetComponent<MeshRenderer>().material = materialChoices[choice];
    }
}
