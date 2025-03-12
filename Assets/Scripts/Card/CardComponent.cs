using TMPro;
using UnityEngine;

public class CardComponent : MonoBehaviour
{
    [SerializeField] private TMP_Text[] textValue;
    [SerializeField] private SpriteRenderer[] spriteValue;
    [SerializeField] private SpriteRenderer centerSprite;
    [SerializeField] private TextMeshPro centerText;
    [SerializeField] private SpriteRenderer background;
    private static readonly int CardColor = Shader.PropertyToID("_CardColor");

    public void SetCardData(CardData cardData, Sprite sprite, bool setSpriteColor = false)
    {
        if (cardData.Value >= 0)
        {
            foreach (var t in textValue)
            {
                t.gameObject.SetActive(true);
                t.text = cardData.CardType == CardData.CardTypeEnum.Plus
                    ? $"+{cardData.Value}"
                    : cardData.Value.ToString();
            }

            foreach (var srValue in spriteValue)
            {
                srValue.gameObject.SetActive(false);
            }
        }
        else
        {
            foreach (var t in spriteValue)
            {
                t.gameObject.SetActive(true);
                t.sprite = sprite;
            }

            foreach (var t in textValue)
            {
                t.gameObject.SetActive(false);
            }
        }

        if (cardData.CardType != CardData.CardTypeEnum.Number)
        {
            centerSprite.gameObject.SetActive(true);
            centerText.gameObject.SetActive(false);
            centerSprite.sprite = sprite;
            centerSprite.color = setSpriteColor ? GetColor(cardData.Color) : Color.white;
        }
        else
        {
            centerSprite.gameObject.SetActive(false);
            centerText.gameObject.SetActive(true);
            centerText.text = cardData.Value.ToString();
            centerText.color = GetColor(cardData.Color);
        }

        // Create a new MaterialPropertyBlock
        MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();
        propertyBlock.SetColor(CardColor, GetColor(cardData.Color));
        background.SetPropertyBlock(propertyBlock);
    }

    private Color GetColor(CardData.CardColorEnum color)
    {
        switch (color)
        {
            case CardData.CardColorEnum.Red:
                return GameConstant.ColorRed;
            case CardData.CardColorEnum.Green:
                return GameConstant.ColorGreen;
            case CardData.CardColorEnum.Blue:
                return GameConstant.ColorBlue;
            case CardData.CardColorEnum.Yellow:
                return GameConstant.ColorYellow;
            default:
                return Color.black;
        }
    }
}