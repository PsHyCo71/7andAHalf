public class HumanPlayer : Player
{
    Input input = new Input();

    public override Cards? DrawCard(Deck deck)
    {
        bool azione = input.run($"Valore corrente: {base.TotalValue()} \n Scegli: Carta[c] Stare[s]", 'c', 's'); // ask if the user wants to draw a card or stay

        if (azione)
        {
            Cards? card = deck.drawCard() ?? throw new Exception("Non ci sono carte rimaste."); // draw card and throw exeption in case there are no cards left

            // if the drawed card is CardMatta set its value following the rules
            if (card.type == Cards.CardsType.CardMatta)
            {
                System.Console.WriteLine("Hai pescato una matta! Se hai altre carte, il suo valore sarà tale da garantire che il totale sia 7.5.");
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
            return card;
        }
        else
        {
            return null;
        }
    }

    // manage the player's turn
    public double Turn(Deck deck)
    {
        while (true)
        {
            Cards? card = this.DrawCard(deck);

            if (card == null)
            {
                break;
            }
            else
            {
                base.AddCard(card);

                if (base.TotalValue() > 7.5)
                {
                    System.Console.WriteLine("Hai sballato.");

                    break;
                }
            }
        }

        return base.TotalValue();
    }
}