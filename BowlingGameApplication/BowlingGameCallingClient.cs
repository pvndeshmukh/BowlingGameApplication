using BowlingService;

namespace BowlingGameApplication;

/// <summary>
/// This is a starting point for console application 
/// Service BowlingGameService is fully abstracted and can easily plug into any UI
/// </summary>
public class BowlingGameCallingClient
{
    public static void CallMe()
    {
        while (true) 
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Strike can be represented by X");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. Spare can be represented by /");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3. Miss can be represented by -");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("4. Knocked down pins can be any number between 1-9");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the sequence of rolls: ");

            string? rolls = Console.ReadLine();

            if (string.IsNullOrEmpty(rolls))
            {
                Console.WriteLine("Please enter some valid input e.g X9/5/72XXX9-8/9/X");
                continue;
            }
            if (rolls.Length >= 10)
            {
                // Inputs can be more validated and scnatized here if necessary...

                int totalScore = new BowlingGameService().CalculateScore(rolls);

                Console.WriteLine("Total score: " + totalScore);
            }
            else
            {
                Console.WriteLine("Please enter some valid input with minimum 10 frames e.g X9/5/72XXX9-8/9/X");
                continue;
            }            
        }
    }
}
