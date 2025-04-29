using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] private CardConfigSO cardConfigSo;

    private List<CardData> GenerateCard()
    {
        var xPos = 0;
        var yPos = 0;
        var cards = new List<CardData>();
        foreach (var cardConfig in cardConfigSo.CardConfigs)
        {
            var listValue = GetValueList(cardConfig.value);
            foreach (var value in listValue)
            {
                var listColor = cardConfig.generateColor == CardData.CardColorEnum.All
                    ? Enumerable.Range(0, 4).Select(x => (CardData.CardColorEnum)x).ToList()
                    : new List<CardData.CardColorEnum> { cardConfig.generateColor };
                foreach (var color in listColor)
                {
                    // var card = Instantiate(cardPrefab, transform); 
                    var cardData = (new CardData(cardConfig.type, value, color), cardConfig.spriteValue,
                        cardConfig.generateColor == CardData.CardColorEnum.All);
                    card.transform.position = new Vector3(xPos, yPos);
                    xPos += 1;
                }
            }

            yPos += 1;
        }
        return cards; 
    }

    private List<int> GetValueList(string valueField)
    {
        if (string.IsNullOrEmpty(valueField)) return new List<int> { -1 };
        if (valueField.Contains('-'))
        {
            var min = int.Parse(valueField.Split('-')[0]);
            var max = int.Parse(valueField.Split('-')[1]);
            return new List<int>(Enumerable.Range(min, max - min + 1));
        }

        return new List<int> { int.Parse(valueField) };
    }
}