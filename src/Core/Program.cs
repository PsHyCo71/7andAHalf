using System;

namespace SevenAndHalfGame;

public class Program
{

    // get rules 
    public Rules? rules { get; set; }
    public static void Main(string[] args)
    {
        Input input = new Input();

        // ask the user if he wants to read the rules

        Console.WriteLine($"Leggere le regole prima di iniziare? Si[s] No[n]");
        while (true)
        {
            char rul = char.Parse(Console.ReadLine()?.Trim().ToLower() ?? "");
            if (rul == 's')
            {
                Rules.ShowRules();   // recall .ShowRules()
                break;
            }
            else if (rul == 'n')
            {
                break;  // don't show rules
            }
            else
            {
                Console.WriteLine("Input non valido. Inserisci 's' o 'n'.");
                continue;
            }
        }

        // use the function .run to start the game
        bool iniziare_partita = input.run("Iniziare partita? Si[s] No[n]", 's', 'n');

        if (iniziare_partita)
        {
            bool first_game = true;     // set this to true bc is the first game
            bool to_play = true;

            // if the user choses 'n' ask again
            if (!first_game)
            {
                to_play = input.run("Vuoi inizare un'altra partita? Si[s] No[n]", 's', 'n');
            }

            // start game
            while (to_play)
            {
                // create deck and shuffle
                Deck deck = new Deck();

                // create players
                HumanPlayer human = new HumanPlayer();
                ComputerPlayer pc = new ComputerPlayer();

                Console.WriteLine("Iniziata una nuova partita.");

                // start user's turn
                while (true)
                {
                    Cards? card = human.DrawCard(deck);
                    if (card == null || human.TotalValue() > 7.5)
                    {
                        break; // the user decided to stay or he busted
                    }
                }
                if (human.TotalValue() > 7.5) // if the user busted
                {
                    Console.WriteLine("Hai sballato! Vince il PC (mazziere).");
                    to_play = input.run("Vuoi inizare un'altra partita? Si[s] No[n]", 's', 'n'); // ask if he wants to play again
                    first_game = false;
                    if (to_play == false)
                    {
                        Console.WriteLine("Uscita dal programma...");
                        break; // if 'n' then close the program
                    }
                continue;
                }
                else
                {
                    // Computer's turn
                    pc.DrawCard(deck);
                }

                // compare the player's points and proclaim winner
                if (pc.TotalValue() > 7.5)
                {
                    Console.WriteLine("Il PC ha sballato! Hai vinto!");
                }
                else if (pc.TotalValue() == 7.5 && human.TotalValue() == 7.5)
                {
                    Console.WriteLine("Entrambi hanno 7.5, ma il mazziere vince! Ha vinto il PC!");
                }
                else if (human.TotalValue() == pc.TotalValue())
                {
                    Console.WriteLine($"Pareggio! Entrambi hanno {human.TotalValue()} punti.");
                }
                else if (human.TotalValue() > pc.TotalValue())
                {
                    Console.WriteLine("Hai vinto!");
                }
                else
                {
                    Console.WriteLine("Ha vinto il PC!");
                }

                // ask if he wants to play again
                to_play = input.run("Vuoi inizare un'altra partita? Si[s] No[n]", 's', 'n');
                first_game = false;
                if (to_play == false)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Uscita dal programma...");
        }
    }
}