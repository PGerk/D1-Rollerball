using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MaterialButton : MonoBehaviour
{
    [SerializeField]
    private int choiceIndex = 0;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => PlayerMaterial.Set(choiceIndex));
    }
}
