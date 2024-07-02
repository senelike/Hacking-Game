using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Canvas infoCanvas; // Info canvas referans�
    public Canvas mainCanvas; // Ana canvas referans�
    public Button infoButton; // Buton referans�

    void Start()
    {
        // Ba�lang��ta Info canvasi pasif yap
        infoCanvas.enabled = false;

        // Butonun onClick olay�na listener ekle
        infoButton.onClick.AddListener(OnInfoButtonClick);
    }

    void Update()
    {
        // ESC tu�una bas�ld���nda Ana canvasi etkinle�tir
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            infoCanvas.enabled = false;
            mainCanvas.enabled = true;
        }
    }

    // Butona t�kland���nda �a�r�lacak fonksiyon
    void OnInfoButtonClick()
    {
        infoCanvas.enabled = true;
        mainCanvas.enabled = false;
    }
}