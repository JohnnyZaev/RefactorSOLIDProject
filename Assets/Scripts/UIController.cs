using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject uiWindow;
    [SerializeField] private Text textField;

    public void ToggleUI(bool value)
    {
        uiWindow.SetActive(value);
    }

    public void ShowText(string text)
    {
        uiWindow.SetActive(true);
        textField.text = text;
    }
}
