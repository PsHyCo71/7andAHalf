using SevenAndHalfGame;

public abstract class Player
{
    Program cardsinhand = new Program();
    protected List<Cards> CardsInHand = new List<Cards>();  // create a list for the drawed cards

    // func for couningt the total points of a player
    public double TotalValue()
    {
        double total = 0;

        foreach (var card in CardsInHand)
        {
            if (card.type == Cards.CardsType.CardMatta)
            {
                // if matta is the only card in hand, its value is equal to 0.5
                // otherwise its value becomes equal to what the player needs to reach 7.5
                double otherCardsTotal = total;
                card.value = (otherCardsTotal == 0) ? 0.5 : Math.Min(7.5 - otherCardsTotal, 7.5);
            }

            total += card.value;
        }

        return total;
    }

    // func for adding cards to the drawed cards's list
    public void AddCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    public Cards? LastCard
    {
        get
        {
            if (CardsInHand.Count == 0)
                return null;

            return CardsInHand.Last();
        }
    }

    public void ReceiveInitialCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    public abstract Cards? DrawCard(Deck deck);
}