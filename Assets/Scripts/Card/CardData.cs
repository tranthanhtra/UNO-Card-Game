public class CardData
{
    public CardTypeEnum CardType { get; private set; }
    public int Value { get; private set; }
    public CardColorEnum Color { get; private set; }

    public CardData( CardTypeEnum cardType, int value, CardColorEnum color )
    {
        CardType = cardType;
        Value = value;
        Color = color;
    }
    
    public enum CardTypeEnum
    {
        Number,
        Plus,
        Reverse,
        Block,
        ChangeColor,
    }

    public enum CardColorEnum
    {
        Red,
        Green,
        Blue,
        Yellow,
        None,
        All
    }
}