using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hacking2_Gidis : MonoBehaviour
{
    // Bu metod oyunu ba�latmak i�in �a�r�l�r
    public void PlayGame()
    {
        // �lk �nce sahnenin do�ru y�klendi�ini kontrol edelim
        if (SceneManager.GetSceneByBuildIndex(2) != null)
        {
            SceneManager.LoadSceneAsync(2);
            Debug.Log("Sahne y�kleniyor: " + 2);
        }
        else
        {
            Debug.LogError("Sahne 1 bulunamad�! L�tfen Build Settings'te sahnenin listelendi�inden emin olun.");
        }
    }
}
