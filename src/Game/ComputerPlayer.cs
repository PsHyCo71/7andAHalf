namespace SevenAndHalfGame;

public class ComputerPlayer : Player
{
    private Random rnd = new Random(); // recall random class
    public override Cards? DrawCard(Deck deck)
    {
        // set the probability for which the PC will ask for a card
        while (TotalValue() < 7.5)
        {
            double prob;
            if (TotalValue() == 0) prob = 1.0;
            else if (TotalValue() <= 3) prob = 0.8;
            else if (TotalValue() <= 5) prob = 0.6;
            else if (TotalValue() <= 6.5) prob = 0.2;
            else if (TotalValue() <= 7) prob = 0.05;
            else prob = 0.0;

            if (rnd.NextDouble() > prob) // if the drawn number is greater than the probability of drawing a card, the PC will stand.
                {
                    Console.WriteLine($"Il PC ha deciso di stare!");
                    break;
                }

            Cards? card = deck.drawCard() ?? throw new Exception("Non ci sono carte rimaste."); // draw card and throw exeption in case there are no cards left

            // if the drawed card is CardMatta set its value following the rules
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

            CardsInHand.Add(card);  // add the drawed card to the drawed cards list
            Console.WriteLine($"PC ha pescato {card.GetSymbol()}, con valore {card.GetValue()}, totale ora {TotalValue()}"); // print the drawed card, its value and the total points

            if (TotalValue() > 7.5)  // case where the PC busts
            {
                Console.WriteLine($"Il PC ha sballato!");
                break;
            }

            
        }

        return null;
    }

}