using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MemoryGame : MonoBehaviour
{
    public GameObject[] cards; // Kartların prefabları
    public Sprite[] images; // Kartların ön yüzü için resimler
    public Button restartButton; // Yeniden başlatma düğmesi

    private GameObject[] shuffledCards; // Karıştırılmış kartlar
    private GameObject firstCard; // İlk seçilen kart
    private GameObject secondCard; // İkinci seçilen kart

    private bool canFlip = true; // Kartların döndürülüp döndürülemeyeceği kontrolü
    private int score = 0; // Skor

    void Start()
    {
        // Kartları oluştur ve karıştır
        InitializeCards();
        ShuffleCards();

        // Yeniden başlatma düğmesinin tıklama olayını dinle
        restartButton.onClick.AddListener(RestartGame);
    }

    void InitializeCards()
    {
        // Kartların sayısı kadar yer aç
        shuffledCards = new GameObject[cards.Length * 2];

        // Her bir kart için iki tane olacak şekilde oluştur ve karıştır
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int index = i * 2 + j;
                shuffledCards[index] = Instantiate(cards[i], transform);
                int imageIndex = Random.Range(0, images.Length);
                shuffledCards[index].GetComponentInChildren<Image>().sprite = images[imageIndex];
            }
        }
    }

    void ShuffleCards()
    {
        // Kartları karıştır
        for (int i = 0; i < shuffledCards.Length; i++)
        {
            int randomIndex = Random.Range(i, shuffledCards.Length);
            GameObject temp = shuffledCards[randomIndex];
            shuffledCards[randomIndex] = shuffledCards[i];
            shuffledCards[i] = temp;
        }
    }

    IEnumerator FlipBack()
    {
        // Yanlış eşleşme durumunda kartları geri döndür
        yield return new WaitForSeconds(1f);
        firstCard.GetComponentInChildren<Image>().enabled = true;
        secondCard.GetComponentInChildren<Image>().enabled = true;
        firstCard = null;
        secondCard = null;
        canFlip = true;
    }

    void RestartGame()
    {
        // Oyunu yeniden başlat
        score = 0;
        foreach (GameObject card in shuffledCards)
        {
            Destroy(card);
        }
        InitializeCards();
        ShuffleCards();
    }

    public void CardClicked(GameObject card)
    {
        // Kart tıklandığında
        if (!canFlip) return;

        // Kartı döndür
        card.GetComponentInChildren<Image>().enabled = false;

        // İlk kartı seç
        if (firstCard == null)
        {
            firstCard = card;
        }
        else
        {
            // İkinci kartı seç ve kontrol et
            secondCard = card;
            if (firstCard.GetComponentInChildren<Image>().sprite == secondCard.GetComponentInChildren<Image>().sprite)
            {
                // Eşleşme varsa kartları sil ve skoru artır
                Destroy(firstCard);
                Destroy(secondCard);
                score++;
                if (score == cards.Length)
                {
                    // Oyun bittiğinde
                    Debug.Log("Oyun bitti!");
                }
            }
            else
            {
                // Eşleşme yoksa kartları geri döndür
                canFlip = false;
                StartCoroutine(FlipBack());
            }
        }
    }
}
