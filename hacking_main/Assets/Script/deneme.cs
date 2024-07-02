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
            // Dönme animasyonu burada gerçekleştirilebilir.
            isFlipped = true;
        }
    }

    public void Unflip()
    {
        if (isFlipped)
        {
            // Dönme animasyonunun tersi burada gerçekleştirilebilir.
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
        // Kartın eşleşip eşleşmediğini kontrol etmek için bu metodu kullanabilirsiniz.
        // Kartlar eşleştiğinde bir işlem gerçekleştirmelisiniz.
    }
}
