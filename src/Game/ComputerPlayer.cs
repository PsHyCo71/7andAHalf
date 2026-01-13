namespace SevenAndHalfGame;

public class ComputerPlayer : Player
{
    private Random rnd = new Random();
    public override Cards? DrawCard(Deck deck)
    {
        while (TotalValue() < 7.5)
        {
            double prob;
            if (TotalValue() == 0) prob = 1.0;
            else if (TotalValue() <= 3) prob = 0.8;
            else if (TotalValue() <= 5) prob = 0.6;
            else if (TotalValue() <= 6.5) prob = 0.2;
            else if (TotalValue() <= 7) prob = 0.05;
            else prob = 0.0;

            if (rnd.NextDouble() > prob)
                {
                    Console.WriteLine($"Il PC ha deciso di stare!");
                    break;
                }

            Cards? card = deck.drawCard() ?? throw new Exception("Non ci sono carte rimaste.");

            if (card.type == Cards.CardsType.CardMatta)
            {
                if (TotalValue() == 0)
                {
                    card.value = 0.5;
                }
                else
                {
                    card.value = 7.5 - TotalValue();
                }
            }

            CardsInHand.Add(card);
            Console.WriteLine($"PC ha pescato {card.GetSymbol()}, con valore {card.GetValue()}, totale ora {TotalValue()}");

            if (TotalValue() > 7.5)
            {
                Console.WriteLine($"Il PC ha sballato!");
                break;
            }

            
        }

        return null;
    }

}