public abstract class Player
{
    protected List<Cards> CardsInHand = new List<Cards>();

    public double TotalValue()
    {
        return CardsInHand.Sum(card => card.GetValue());
    }

    public void AddCard(Cards card)
    {
        CardsInHand.Add(card);
    }

    public abstract Cards? DrawCard(Deck deck);
}