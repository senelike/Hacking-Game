using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking3_Gidis : MonoBehaviour
{
    // Bu metod oyunu baþlatmak için çaðrýlýr
    public void PlayGame()
    {
        // Ýlk önce sahnenin doðru yüklendiðini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(3) != null)
        {
            SceneManager.LoadSceneAsync(3);
            Debug.Log("Sahne yükleniyor: " + 3);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamadý! Lütfen Build Settings'te sahnenin listelendiðinden emin olun.");
        }
    }
}
