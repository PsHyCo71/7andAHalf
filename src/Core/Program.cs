using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using SevenAndAHalf.Services;

namespace SevenAndHalfGame;

public class Program
{
    // Property to store game rules
    public Rules? rules { get; set; }

    // Property to track cards in hand (not used directly in this class)
    public Player? CardsInHand { get; set; }

    /// <summary>
    /// Main entry point of the 7 and a half game.
    /// Handles language selection, rules display, and game loop.
    /// </summary>
    /// <param name="args">Command line arguments (not used)</param>
    public static void Main(string[] args)
    {
        Input input = new Input();

        // Language selection loop
        while (true)
        {
            Console.WriteLine("Language? 1) Italiano 2) English");
            string choice = Console.ReadLine()?.Trim().ToLower() ?? "";
            if (choice == "1")
            {
                Lang.SetLanguage(Language.IT); // Set Italian
                break;
            }
            else if (choice == "2")
            {
                Lang.SetLanguage(Language.EN); // Set English
                break;
            }
            else
            {
                continue; // Invalid input, repeat
            }
        }

        // Ask the user if they want to read the rules
        bool showrules = input.run(Lang.Translation("show_rules"), 'y', 's', 'n');
        if (showrules == true)
        {
            Rules.ShowRules();   // Display the rules
        }

        // Ask the user if they want to start the game
        bool iniziare_partita = input.run(Lang.Translation("start_round"), 'y', 's', 'n');

        if (iniziare_partita)
        {
            bool first_game = true;     // First game flag
            bool to_play = true;

            // Ask for a new game if it's not the first
            if (!first_game)
            {
                to_play = input.run(Lang.Translation("start_new_round"), 'y', 's', 'n');
            }

            // Main game loop
            while (to_play)
            {
                // Create and shuffle a new deck
                Deck deck = new Deck();

                // Create human and computer players
                HumanPlayer human = new HumanPlayer();
                ComputerPlayer pc = new ComputerPlayer();

                Console.WriteLine(Lang.Translation("start_new_game"));

                // Start the human player's turn
                Cards firstCard = deck.drawCard() ?? throw new Exception(Lang.Translation("no_cards"));
                human.ReceiveInitialCard(firstCard);

                human.Turn(deck);

                // Track last card and total points
                char lastCard = human.LastCard != null ? human.LastCard.GetSymbol() : '?';
                double total = human.TotalValue();

                if (human.TotalValue() > 7.5) // Player busts
                {
                    Console.WriteLine(Lang.Translation("player_bust", lastCard, total));
                    to_play = input.run(Lang.Translation("start_new_round"), 'y', 's', 'n'); // Ask to play again
                    first_game = false;
                    if (to_play == false)
                    {
                        Console.WriteLine(Lang.Translation("exit"));
                        break; // Exit program
                    }
                    continue;
                }
                else
                {
                    // Computer's turn
                    pc.DrawCard(deck);
                }

                // Compare points and determine the winner
                if (pc.TotalValue() > 7.5)
                {
                    Console.WriteLine(Lang.Translation("pc_bust"));
                }
                else if (pc.TotalValue() == 7.5 && human.TotalValue() == 7.5)
                {
                    Console.WriteLine(Lang.Translation("tie_dealer_wins"));
                }
                else if (human.TotalValue() == pc.TotalValue())
                {
                    Console.WriteLine(Lang.Translation("draw_game", total));
                }
                else if (human.TotalValue() > pc.TotalValue())
                {
                    Console.WriteLine(Lang.Translation("player_wins"));
                }
                else
                {
                    Console.WriteLine(Lang.Translation("pc_wins"));
                }

                // Ask user if they want to play again
                to_play = input.run(Lang.Translation("start_new_round"), 'y', 's', 'n');
                first_game = false;
                if (to_play == false)
                {
                    Console.WriteLine(Lang.Translation("exit"));
                    break; // Exit game loop
                }
            }
        }
        else
        {
            // User chose not to start the game
            Console.WriteLine(Lang.Translation("exit"));
        }
    }
}
