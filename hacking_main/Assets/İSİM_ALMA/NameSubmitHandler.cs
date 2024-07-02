using UnityEngine;
using UnityEngine.UI;

public class NameSubmitHandler : MonoBehaviour
{
    public InputField nameInputField;
    public Button submitButton;
    public Text promptText;
    public Text resultText;
    public Text nameOnlyText;

    void Start()
    {
        // Butona t�klama olay�n� ekle
        submitButton.onClick.AddListener(OnSubmit);
        // Sonu� metinlerini ba�lang��ta gizle
        resultText.gameObject.SetActive(false);
        nameOnlyText.gameObject.SetActive(false);
    }

    void OnSubmit()
    {
        // Input Field'dan ismi al
        string playerName = nameInputField.text;
        // Metinleri g�ncelle
        resultText.text = "Hacked by " + playerName;
        nameOnlyText.text = playerName;
        // Input Field, Button ve Prompt Text'i gizle
        nameInputField.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
        promptText.gameObject.SetActive(false);
        // Sonu� metinlerini g�ster
        resultText.gameObject.SetActive(true);
        nameOnlyText.gameObject.SetActive(true);
    }
}
