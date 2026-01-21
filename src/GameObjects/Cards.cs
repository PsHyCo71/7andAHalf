using System.Dynamic;
using SevenAndAHalf.Services;

public class Cards
{
    // create all the cards
    public enum CardsType
    {
        Card1,
        Card2,
        Card3,
        Card4,
        Card5,
        Card6,
        Card7,
        CardFante,
        CardCavallo,
        CardRe,
        CardMatta,
    }

    /// <summary>
    /// Represents a playing card in the game.
    /// </summary>
    public double value; // The numerical value of the card (1–7 or 0.5 for face cards)

    /// <summary>
    /// The type of the card (numbered, face card, or wild card).
    /// </summary>
    public CardsType type { get; private set; }

    /// <summary>
    /// Constructs a standard card with a specific type (numbered or face card).
    /// Throws an exception if trying to create a wild card with this constructor.
    /// </summary>
    /// <param name="type">The type of the card to create.</param>
    public Cards(CardsType type)
    {
        this.type = type;

        // Wild card cannot be created using this constructor
        if (type == CardsType.CardMatta)
        {
            throw new Exception(Lang.Translation("not_supposed"));
        }

        // Set the card's value according to its type
        this.value = _GetValue();
    }

    /// <summary>
    /// Constructs a wild card (CardMatta) with a specific value.
    /// </summary>
    /// <param name="value">The value to assign to the wild card.</param>
    public Cards(double value)
    {
        this.type = CardsType.CardMatta;
        this.value = value;
    }


    public static Language currentLanguage { get; set; } // get currentLanguage from Lang

    /// <summary>
    /// Returns symbol of the card for display
    /// </summary>
    public char GetSymbol()
    {
        switch (type)
        {
            case CardsType.Card1:
                return '1';
            case CardsType.Card2:
                return '2';
            case CardsType.Card3:
                return '3';
            case CardsType.Card4:
                return '4';
            case CardsType.Card5:
                return '5';
            case CardsType.Card6:
                return '6';
            case CardsType.Card7:
                return '7';
            case CardsType.CardFante:
                return Cards.currentLanguage == Language.IT ? 'F' : 'J';
            case CardsType.CardCavallo:
                return Cards.currentLanguage == Language.IT ? 'C' : 'Q';
            case CardsType.CardRe:
                return Cards.currentLanguage == Language.IT ? 'R' : 'K';
            case CardsType.CardMatta:
                return Cards.currentLanguage == Language.IT ? 'M' : 'J';
            default:
                throw new System.Exception(Lang.Translation("invalid_card"));
        }
    }

    /// <summary>
    /// Sets the default value of a card based on its type
    /// </summary>
    private double _GetValue()
    {
        switch (type)
        {
            case CardsType.Card1:
                return 1;
            case CardsType.Card2:
                return 2;
            case CardsType.Card3:
                return 3;
            case CardsType.Card4:
                return 4;
            case CardsType.Card5:
                return 5;
            case CardsType.Card6:
                return 6;
            case CardsType.Card7:
                return 7;
            case CardsType.CardFante:
            case CardsType.CardCavallo:
            case CardsType.CardRe:
            case CardsType.CardMatta:
                return 0.5;
            default:
                throw new System.Exception(Lang.Translation("invalid_card"));
        }
    }

    public double GetValue()
    {
        return this.value;
    }
}