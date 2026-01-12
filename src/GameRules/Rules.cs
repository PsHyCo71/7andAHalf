using SevenAndHalfGame;

public class Rules
{
    Program rules = new Program();
    public static void ShowRules()
    {
        System.Console.WriteLine("Regole del gioco 7 e mezzo:");
        System.Console.WriteLine("1. Lo scopo del gioco è avvicinarsi il più possibile a 7.5 punti senza superarlo.");
        System.Console.WriteLine("2. Le carte numerate da 1 a 7 valgono il loro valore nominale in punti.");
        System.Console.WriteLine("3. Le figure (Fante, Cavallo, Re) valgono 0.5 punti ciascuna.");
        System.Console.WriteLine("4. La Matta può valere 0.5 punti o il valore necessario per raggiungere esattamente 7.5 punti, se si hanno altre carte in mano.");
        System.Console.WriteLine("5. I giocatori possono scegliere di pescare un'altra carta o stare.");
        System.Console.WriteLine("6. Se un giocatore supera i 7.5 punti, perde automaticamente la partita.");
        System.Console.WriteLine("7. Se il giocatore decide di stare, allora inizia il turno del computer.");
        System.Console.WriteLine("Buona fortuna e buon divertimento!");
    }
}