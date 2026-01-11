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
                System.Console.WriteLine("Hai pescato una matta; inserisci un valore per la matta:");
                double valore = //input qui
                card = new Cards(valore);
            }

            return card;
        } else
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
            } else
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