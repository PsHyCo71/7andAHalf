using SevenAndHalfGame;

public abstract class Player
{
    // Reference to Program (not really used)
    Program cardsinhand = new Program();

    // List of cards in player's hand
    protected List<Cards> CardsInHand = new List<Cards>();

    /// <summary>
    /// Calculates the total value of the cards in hand
    /// </summary>
    /// <returns>Total points of player</returns>
    public double TotalValue()
    {
        double total = 0;

        foreach (var card in CardsInHand)
        {
            if (card.type == Cards.CardsType.CardMatta)
            {
                // Adjust wild card value
                double otherCardsTotal = total;
                card.value = (otherCardsTotal == 0) ? 0.5 : Math.Min(7.5 - otherCardsTotal, 7.5);
            }

            total += card.value;
        }

        return total;
    }

    /// <summary>
    /// Adds a card to the player's hand
    /// </summary>
    public void AddCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    /// <summary>
    /// Returns the last card drawn by the player
    /// </summary>
    public Cards? LastCard
    {
        get
        {
            if (CardsInHand.Count == 0)
                return null;

            return CardsInHand.Last();
        }
    }

    /// <summary>
    /// Receives the initial card at the start of the turn
    /// </summary>
    public void ReceiveInitialCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    /// <summary>
    /// Abstract method for drawing a card (implemented by HumanPlayer or ComputerPlayer)
    /// </summary>
    public abstract Cards? DrawCard(Deck deck);
}
