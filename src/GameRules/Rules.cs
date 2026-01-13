using System;
using SevenAndHalfGame;

public class Rules
{
    Program rules = new Program();
    
    // func for printing rules
    public static void ShowRules()
    {
        Console.WriteLine("Regole del gioco 7 e mezzo:");
        Console.WriteLine("1. Lo scopo del gioco è avvicinarsi il più possibile a 7.5 punti senza superarlo.");
        Console.WriteLine("2. Le carte numerate da 1 a 7 valgono il loro valore nominale in punti.");
        Console.WriteLine("3. Le figure (Fante, Cavallo, Re) valgono 0.5 punti ciascuna.");
        Console.WriteLine("4. La Matta può valere 0.5 punti o il valore necessario per raggiungere esattamente 7.5 punti, se si hanno altre carte in mano.");
        Console.WriteLine("5. I giocatori possono scegliere di pescare un'altra carta o stare.");
        Console.WriteLine("6. Se un giocatore supera i 7.5 punti, perde automaticamente la partita.");
        Console.WriteLine("7. Se il giocatore decide di stare, allora inizia il turno del computer.");
        Console.WriteLine("8. Se il giocatore o il computer raggiungono esattamente 7.5 punti, vincono automaticamente la partita.");
        Console.WriteLine("9. Se entrambi hanno 7.5 punti, vince il computer perchè si tratta del mazziere.");
        Console.WriteLine("Buona fortuna e buon divertimento!");
    }
}