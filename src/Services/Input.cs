using System;

public class Input
{
    
    public bool run(string query, char ok, char no)
    {
        while (true)
        {
            Console.WriteLine(query);
            string? line = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrEmpty(line))
            {
                Console.WriteLine("Input non valido, riprova.");
                continue;
            }

            char choice = line[0];
            if (choice == ok)
                return true;
            else if (choice == no)
                return false;
            else
                Console.WriteLine($"Inserisci '{ok}' per sì o '{no}' per no.");
        }
    }
}