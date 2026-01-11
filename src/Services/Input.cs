using System.Linq;

public class Input
{
    public bool run(
        string query,
        char ok,
        char no
    )
    {
        bool has_retried = false;

        while (true)
        {
            System.Console.WriteLine(query);
            
            if (has_retried)
            {
                System.Console.WriteLine($"Digita {ok} per si, o {no} per no.");
            }

            char? input = Console.ReadLine()?.Trim().ToLower()[0] ;
            
            if (input == null || input != ok || input != no)
            {
                has_retried = true;
                continue;
            } else if (input == ok)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    public double run_numerico(string query, double[] excluded)
    {
        bool has_retried = false;

        while (true)
        {
            System.Console.WriteLine(query);
            
            if (has_retried)
            {
                System.Console.WriteLine($"Inserisci un numero valido:");
            }


            string? input = Console.ReadLine()?.Trim().ToLower();
            
            if (input == null )
            {
                has_retried = true;
                continue;
            } else
            {
                double? input_parsed = double.Parse(input);

                if (excluded.Contains(input_parsed))
                {
                    
                }
            }
        }
    }
}