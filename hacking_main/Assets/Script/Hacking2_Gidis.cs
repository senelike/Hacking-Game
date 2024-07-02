using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking2_Gidis : MonoBehaviour
{
    // Bu metod oyunu baþlatmak için çaðrýlýr
    public void PlayGame()
    {
        // Ýlk önce sahnenin doðru yüklendiðini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(2) != null)
        {
            SceneManager.LoadSceneAsync(2);
            Debug.Log("Sahne yükleniyor: " + 2);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamadý! Lütfen Build Settings'te sahnenin listelendiðinden emin olun.");
        }
    }
}
