using SevenAndAHalf.Services;

namespace SevenAndHalfGame;

/// <summary>
/// Represents the computer (AI) player in the game.
/// Implements automatic card drawing based on probabilities.
/// </summary>
public class ComputerPlayer : Player
{
    // Random number generator for probabilistic card drawing
    private Random rnd = new Random();

    /// <summary>
    /// Executes the computer player's turn.
    /// Draws cards until the AI decides to stay or busts.
    /// </summary>
    /// <param name="deck">The deck from which to draw cards</param>
    /// <returns>Always returns null because cards are managed internally</returns>
    public override Cards? DrawCard(Deck deck)
    {
        // Continue drawing while total value is less than 7.5
        while (TotalValue() < 7.5)
        {
            double prob;

            // Determine probability to draw another card based on current total
            if (TotalValue() == 0) prob = 1.0;
            else if (TotalValue() <= 3) prob = 0.8;
            else if (TotalValue() <= 5) prob = 0.6;
            else if (TotalValue() <= 6.5) prob = 0.2;
            else if (TotalValue() <= 7) prob = 0.05;
            else prob = 0.0;

            // Decide whether to stay based on probability
            if (rnd.NextDouble() > prob)
            {
                Console.WriteLine(Lang.Translation("pc_stay")); // AI decides to stay
                break;
            }

            // Draw a card from the deck
            Cards? card = deck.drawCard() ?? throw new Exception(Lang.Translation("no_cards"));

            // Adjust value if the drawn card is a wild card (CardMatta)
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

            // Add drawn card to computer's hand
            CardsInHand.Add(card);

            // Print info about drawn card
            Console.WriteLine(Lang.Translation("pc_drew", card.GetSymbol(), card.GetValue(), TotalValue()));

            // Stop if computer busts
            if (TotalValue() > 7.5)
            {
                break;
            }
        }

        // Return null because this method does not need to return a card
        return null;
    }
}
