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

    public double value;
    public CardsType type {get; private set;}

    public Cards(CardsType type)
    {
        this.type = type;
        if (type == CardsType.CardMatta)
        {
            throw new Exception("Questo non dovrebbe succedere.");
        }
        this.value = _GetValue();
    }

    public Cards(double value)
    {
        this.type = CardsType.CardMatta;
        this.value = value;
    }

    // set the cards symbols
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
                return 'F';
            case CardsType.CardCavallo:
                return 'C';
            case CardsType.CardRe:
                return 'R';
            case CardsType.CardMatta:
                return 'M';
            default:
                throw new System.Exception("Carta non valida");
        }
    }

    // set cards values
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
                throw new System.Exception("Carta non valida");
        }
    }

    public double GetValue()
    {
        return this.value;
    }
}