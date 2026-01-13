public abstract class Player
{
    protected List<Cards> CardsInHand = new List<Cards>();  // create a list for the drawed cards

    // func for couningt the total points of a player
    public double TotalValue()
    {
        return CardsInHand.Sum(card => card.GetValue());
    }

    // func for adding cards to the drawed cards's list
    public void AddCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    public abstract Cards? DrawCard(Deck deck);
}