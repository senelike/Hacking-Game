using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baslangic_Gidis : MonoBehaviour
{
    // Bu metod oyunu baþlatmak için çaðrýlýr
    public void PlayGame()
    {
        // Ýlk önce sahnenin doðru yüklendiðini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(0) != null)
        {
            SceneManager.LoadSceneAsync(0);
            Debug.Log("Sahne yükleniyor: " + 0);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamadý! Lütfen Build Settings'te sahnenin listelendiðinden emin olun.");
        }
    }

    // Update metodunda Tab tuþuna basýlýp basýlmadýðýný kontrol et
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PlayGame();
        }
    }
}
