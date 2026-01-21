using System;
using SevenAndAHalf.Services;

public class Input
{
    /// <summary>
    /// Handles user input for yes/no or other options
    /// </summary>
    /// <param name="query">Message to display</param>
    /// <param name="okeng">Yes for English</param>
    /// <param name="okit">Yes for Italian</param>
    /// <param name="no">No</param>
    /// <returns>True if user selects yes, false if no</returns>
    public bool run(string query, char okeng, char okit, char no)
    {
        while (true)
        {
            Console.WriteLine(query);
            string? line = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrEmpty(line))
            {
                Console.WriteLine(Lang.Translation("invalid_input"));
                continue;
            }
            char choice = line[0];
            if (choice == okeng || choice == okit)
            {
                return true;
            }
            else if (choice == no)
            {
                return false;
            }
            else
            {
                Console.WriteLine(Lang.Translation("ask_input_ok_no", okeng, okit, no));
            }
        }
    }
}
