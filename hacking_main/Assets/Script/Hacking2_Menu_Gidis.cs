using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking2_Menu_Gidis : MonoBehaviour
{
    // Bu metod oyunu ba�latmak i�in �a�r�l�r
    public void PlayGame()
    {
        // �lk �nce sahnenin do�ru y�klendi�ini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(1) != null )
        {
            SceneManager.LoadSceneAsync(1);
            Debug.Log("Sahne y�kleniyor: " + 1);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamad�! L�tfen Build Settings'te sahnenin listelendi�inden emin olun.");
        }
    }

    // Update metodunda Tab tu�una bas�l�p bas�lmad���n� kontrol et
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PlayGame();
        }
    }
}
