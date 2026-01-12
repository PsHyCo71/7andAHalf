public class HumanPlayer : Player
{
    Input input = new Input();

    public override Cards? DrawCard(Deck deck)
    {
        bool azione = input.run($"Valore corrente: {base.TotalValue()} \n Scegli: Carta[c] Stare[s]", 'c', 's');

        if (azione)
        {
            Cards? card = deck.drawCard() ?? throw new Exception("Non ci sono carte rimaste.");
            if (card.type == Cards.CardsType.CardMatta)
            {
                System.Console.WriteLine("Hai pescato una matta! Se hai altre carte, il suo valore sarà calcolato secondo le regole del gioco.");
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
            return card;
        }
        else
        {
            return null;
        }
    }

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