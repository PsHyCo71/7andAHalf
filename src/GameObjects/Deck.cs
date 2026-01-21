public class Deck
{
    Random random = new Random();
    List<Cards> deck = new List<Cards>();

    /// <summary>
    /// Initializes a deck with all cards and shuffles it
    /// </summary>
    public Deck()
    {
        this.addCards(8, new Cards(Cards.CardsType.Card1));
        this.addCards(8, new Cards(Cards.CardsType.Card2));
        this.addCards(8, new Cards(Cards.CardsType.Card3));
        this.addCards(8, new Cards(Cards.CardsType.Card4));
        this.addCards(8, new Cards(Cards.CardsType.Card5));
        this.addCards(8, new Cards(Cards.CardsType.Card6));
        this.addCards(8, new Cards(Cards.CardsType.Card7));
        this.addCards(8, new Cards(Cards.CardsType.CardFante));
        this.addCards(8, new Cards(Cards.CardsType.CardCavallo));
        this.addCards(6, new Cards(Cards.CardsType.CardRe));
        this.addCards(2, new Cards(0.0)); // Matta

        deck = deck.Shuffle().ToList(); // Shuffle deck
    }

    // Add multiple copies of a card
    private void addCards(int n_cards, Cards card)
    {
        for (int n = 0; n < n_cards; n++)
        {
            deck.Add(card);
        }
    }

    /// <summary>
    /// Draws a card from the deck
    /// </summary>
    public Cards? drawCard()
    {
        if (deck.Count() == 0) return null;

        Cards card = deck[0];
        deck.RemoveAt(0);

        if (card.type == Cards.CardsType.CardMatta)
        {
            deck = deck.Shuffle().ToList(); // Shuffle after Matta
        }

        return card;
    }
}