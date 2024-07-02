using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking3_Gidis : MonoBehaviour
{
    // Bu metod oyunu ba�latmak i�in �a�r�l�r
    public void PlayGame()
    {
        // �lk �nce sahnenin do�ru y�klendi�ini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(3) != null)
        {
            SceneManager.LoadSceneAsync(3);
            Debug.Log("Sahne y�kleniyor: " + 3);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamad�! L�tfen Build Settings'te sahnenin listelendi�inden emin olun.");
        }
    }
}
