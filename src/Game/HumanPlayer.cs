using SevenAndAHalf.Services;

public class HumanPlayer : Player
{
    // Input handler for asking the user
    Input input = new Input();

    /// <summary>
    /// Executes a human player's action for one turn (draw or stay)
    /// </summary>
    /// <param name="deck">Deck to draw cards from</param>
    /// <returns>The card drawn, or null if player stays</returns>
    public override Cards? DrawCard(Deck deck)
    {
        bool azione;

        // Different message if it's the first card or subsequent cards
        if (CardsInHand.Count() == 1)
        {
            string prompt_1 = Lang.Translation("first_turn_query", CardsInHand.Last().GetSymbol(), base.TotalValue());
            azione = input.run(prompt_1, 'c', 'c', 's'); // Ask user: draw or stay
        }
        else
        {
            string prompt_2 = Lang.Translation("subsequent_turn_query", CardsInHand.Last().GetSymbol(), base.TotalValue());
            azione = input.run(prompt_2, 'c', 'c', 's'); // Ask user: draw or stay
        }

        if (azione)
        {
            // Draw card and throw exception if deck empty
            Cards? card = deck.drawCard() ?? throw new Exception(Lang.Translation("no_cards"));

            // Adjust value if card is a wild card
            if (card.type == Cards.CardsType.CardMatta)
            {
                System.Console.WriteLine(Lang.Translation("draw_matta"));
                if (TotalValue() == 0)
                {
                    card.value = 0.5;
                }
                else
                {
                    card.value = 7.5 - TotalValue();
                }
            }
            return card;
        }
        else
        {
            return null; // Player chose to stay
        }
    }

    /// <summary>
    /// Manages the player's full turn until they stay or bust
    /// </summary>
    /// <param name="deck">Deck to draw cards from</param>
    /// <returns>Total points after turn</returns>
    public double Turn(Deck deck)
    {
        while (true)
        {
            Cards? card = this.DrawCard(deck);

            if (card == null) // player chose to stay
            {
                break;
            }
            else
            {
                base.AddCard(card); // Add drawn card to hand

                // Check if player busted
                if (base.TotalValue() > 7.5)
                {
                    System.Console.WriteLine(Lang.Translation("player_bust_short"));
                    break;
                }
            }
        }

        return base.TotalValue();
    }
}
