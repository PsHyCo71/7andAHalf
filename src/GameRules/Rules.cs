using System;
using SevenAndHalfGame;
using SevenAndAHalf.Services;

public class Rules
{
    Program rules = new Program();
    
    // func for printing rules
    public static void ShowRules()
    {
        Console.WriteLine(Lang.Translation("rules_header"));
        Console.WriteLine(Lang.Translation("rules_0"));
        Console.WriteLine(Lang.Translation("rules_1"));
        Console.WriteLine(Lang.Translation("rules_2"));
        Console.WriteLine(Lang.Translation("rules_3"));
        Console.WriteLine(Lang.Translation("rules_4"));
        Console.WriteLine(Lang.Translation("rules_5"));
        Console.WriteLine(Lang.Translation("rules_6"));
        Console.WriteLine(Lang.Translation("rules_7"));
        Console.WriteLine(Lang.Translation("rules_8"));
        Console.WriteLine(Lang.Translation("rules_9"));
        Console.WriteLine(Lang.Translation("rules_end"));
    }
}