using System;

// to fix

namespace SevenAndHalfGame;

public class Program
{

    public Rules? rules {get; set; }
    public static void Main()
    {
        Input input = new Input();

        Rules.ShowRules();

        bool iniziare_partita = input.run("Iniziare partita? Si[s] No[n] Leggi le regole[r]", 's', 'n');

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
                HumanPlayer game = new HumanPlayer();
                Console.WriteLine("Iniziata una nuova patita.");
            }
        }
        else if ()
        {
            Console.WriteLine("Uscita dal programma...");
        }

        // while (true)
        // {
        //     string input = Console.ReadLine()?.Trim().ToLower() ?? "";

        //     if (input == "s")
        //     {
        //         var game = new Game();

        //         while (true)
        //         {
        //             Cards firstCard = game.PickCard();
        //             Console.WriteLine($"Prima carta: {firstCard.GetSymbol()}, valore: {firstCard.GetValue()}");

        //             if (firstCard.GetValue() == 3 || firstCard.GetValue() == 4)
        //             {
        //                 Console.WriteLine("Opzione Brucia disponibile!");
        //                 Console.WriteLine("Vuoi bruciare la carta? Si[s] No[n]");
        //                 string burnInput = Console.ReadLine()?.Trim().ToLower() ?? "";
        //                 if (burnInput == "s")
        //                 {
        //                     continue;
        //                 }
        //                 else if (burnInput == "n")
        //                 {
        //                     break;
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine("Input non valido. Inserisci 's' o 'n'.");
        //                 }
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }

        //         while (true)
        //         {
        //             char result = ContinueGame(game);

        //             if (result == 'n')
        //             {
        //                 Console.WriteLine("Uscita dal programma...");
        //                 return;
        //             }
        //             else if (result == 's')
        //             {
        //                 break;
        //             }
        //         }
        //     }
        //     else if (input == "n")
        //     {
        //         Console.WriteLine("Uscita dal programma...");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Input non valido. Inserisci 's' per iniziare o 'n' per uscire.");
        //     }
        // }
    }

    public static char ContinueGame(Player game)
    {
        Console.WriteLine("Scegli: Carta[c] Stare[s]");

        while (true)
        {
            string input = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (input == "c")
            {
                Cards newCard = game.PickCard();
                double total = game.TotalValue;
                Console.WriteLine($"Carta pescata: {newCard.GetSymbol()}, valore: {newCard.GetValue()}, totale: {total}");

                if (total > 7.5)
                {
                    Console.WriteLine("Hai sballato!");

                    while (true)
                    {
                        Console.WriteLine("Vuoi iniziare una nuova partita? Si[s] No[n]");
                        string choice = Console.ReadLine()?.Trim().ToLower() ?? "";

                        if (choice == "s")
                            return 's';
                        else if (choice == "n")
                            return 'n';
                        else
                            Console.WriteLine("Input non valido. Inserisci 's' o 'n'.");
                    }
                }
                else
                {
                    Console.WriteLine("Vuoi continuare? Carta[c] Stare[s]");
                    continue;
                }
            }
            else if (input == "s")
            {
                Console.WriteLine($"Hai scelto di stare con un valore totale di {game.TotalValue}");
                return 's';
            }
            else
            {
                Console.WriteLine("Input non valido. Inserisci 'c' per carta o 's' per stare.");
            }
        }
    }
}