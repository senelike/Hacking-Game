using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    private int cardID;
    private bool isFlipped = false;
    private bool canBeFlipped = true;
    private SpriteRenderer spriteRenderer;

    public int CardID { get { return cardID; } }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (canBeFlipped)
        {
            Flip();
            CheckMatch();
        }
    }

    public void InitializeCard(int id, Sprite image)
    {
        cardID = id;
        spriteRenderer.sprite = image;
    }

    public void Flip()
    {
        if (!isFlipped)
        {
            // D�nme animasyonu burada ger�ekle�tirilebilir.
            isFlipped = true;
        }
    }

    public void Unflip()
    {
        if (isFlipped)
        {
            // D�nme animasyonunun tersi burada ger�ekle�tirilebilir.
            isFlipped = false;
        }
    }

    public void DisableFlip()
    {
        canBeFlipped = false;
    }

    public void EnableFlip()
    {
        canBeFlipped = true;
    }

    private void CheckMatch()
    {
        // Kart�n e�le�ip e�le�medi�ini kontrol etmek i�in bu metodu kullanabilirsiniz.
        // Kartlar e�le�ti�inde bir i�lem ger�ekle�tirmelisiniz.
    }
}
