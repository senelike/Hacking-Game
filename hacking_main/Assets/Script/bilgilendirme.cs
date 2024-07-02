using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Canvas infoCanvas; // Info canvas referansý
    public Canvas mainCanvas; // Ana canvas referansý
    public Button infoButton; // Buton referansý

    void Start()
    {
        // Baþlangýçta Info canvasi pasif yap
        infoCanvas.enabled = false;

        // Butonun onClick olayýna listener ekle
        infoButton.onClick.AddListener(OnInfoButtonClick);
    }

    void Update()
    {
        // ESC tuþuna basýldýðýnda Ana canvasi etkinleþtir
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            infoCanvas.enabled = false;
            mainCanvas.enabled = true;
        }
    }

    // Butona týklandýðýnda çaðrýlacak fonksiyon
    void OnInfoButtonClick()
    {
        infoCanvas.enabled = true;
        mainCanvas.enabled = false;
    }
}