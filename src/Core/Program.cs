using System;

namespace SevenAndHalfGame;

public class Program
{

    public Rules? rules { get; set; }
    public static void Main(string[] args)
    {
        Input input = new Input();

        Console.WriteLine($"Leggere le regole prima di iniziare? Si[s] No[n]");
        while (true)
        {
            char rul = char.Parse(Console.ReadLine()?.Trim().ToLower() ?? "");
            if (rul == 's')
            {
                Rules.ShowRules();
                break;
            }
            else if (rul == 'n')
            {
                break;
            }
            else
            {
                Console.WriteLine("Input non valido. Inserisci 's' o 'n'.");
                continue;
            }
        }


        bool iniziare_partita = input.run("Iniziare partita? Si[s] No[n]", 's', 'n');

        if (iniziare_partita)
        {
            bool first_game = true;
            bool to_play = true;

            if (!first_game)
            {
                to_play = input.run("Vuoi inizare un'altra partita? Si[s] No[n]", 's', 'n');
            }

            while (to_play)
            {
                // 1️⃣ Creazione mazzo e shuffle
                Deck deck = new Deck();

                // 2️⃣ Creazione giocatori
                HumanPlayer human = new HumanPlayer();
                ComputerPlayer pc = new ComputerPlayer();

                Console.WriteLine("Iniziata una nuova partita.");

                // 3️⃣ Turno HumanPlayer
                while (true)
                {
                    Cards? card = human.DrawCard(deck);
                    if (card == null || human.TotalValue() > 7.5)
                    {
                        break; // L'utente ha deciso di stare o ha sballato
                    }
                }
                if (human.TotalValue() > 7.5)
                {
                    Console.WriteLine("Hai sballato! Vince il PC (mazziere).");
                    to_play = input.run("Vuoi inizare un'altra partita? Si[s] No[n]", 's', 'n');
                    first_game = false;
                    if (to_play == false)
                    {
                        Console.WriteLine("Uscita dal programma...");
                        break;
                    }
                continue;
                }
                else
                {
                    // 4️⃣ Turno ComputerPlayer (automatico)
                    pc.DrawCard(deck);
                }

                // 5️⃣ Confronto dei punteggi e vincitore
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

                // 6️⃣ Chiedere se vuole fare un'altra partita
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