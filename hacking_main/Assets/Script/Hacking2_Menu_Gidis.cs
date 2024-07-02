using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking2_Menu_Gidis : MonoBehaviour
{
    // Bu metod oyunu baþlatmak için çaðrýlýr
    public void PlayGame()
    {
        // Ýlk önce sahnenin doðru yüklendiðini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(1) != null )
        {
            SceneManager.LoadSceneAsync(1);
            Debug.Log("Sahne yükleniyor: " + 1);
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
