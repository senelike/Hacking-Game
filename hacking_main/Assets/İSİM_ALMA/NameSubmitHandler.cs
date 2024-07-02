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
        // Butona týklama olayýný ekle
        submitButton.onClick.AddListener(OnSubmit);
        // Sonuç metinlerini baþlangýçta gizle
        resultText.gameObject.SetActive(false);
        nameOnlyText.gameObject.SetActive(false);
    }

    void OnSubmit()
    {
        // Input Field'dan ismi al
        string playerName = nameInputField.text;
        // Metinleri güncelle
        resultText.text = "Hacked by " + playerName;
        nameOnlyText.text = playerName;
        // Input Field, Button ve Prompt Text'i gizle
        nameInputField.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
        promptText.gameObject.SetActive(false);
        // Sonuç metinlerini göster
        resultText.gameObject.SetActive(true);
        nameOnlyText.gameObject.SetActive(true);
    }
}
