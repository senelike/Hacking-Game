using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    // Kaydedilecek veriler
    public int playerScore;
    public Vector3 playerPosition;

    void Awake()
    {
        // Singleton yapýsýný koru
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Tab tuþuna basýldýðýnda sahne deðiþtir
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Aktif sahneyi al
            Scene currentScene = SceneManager.GetActiveScene();
            // Geçiþ yapacaðýnýz sahnenin ismini belirleyin
            string nextSceneName = currentScene.name == "Scene1" ? "Scene2" : "Scene1";
            // Yeni sahneyi yükle
            SceneManager.LoadScene(nextSceneName);
        }

        // Verileri kaydetmek için örnek kod (Örn: Boþluk tuþuna basýldýðýnda)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerScore += 10;
            if (GameObject.FindWithTag("Player") != null)
            {
                playerPosition = GameObject.FindWithTag("Player").transform.position;
            }
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Oyuncu pozisyonunu sahne yüklendiðinde güncelle
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            player.transform.position = playerPosition;
        }
    }
}
