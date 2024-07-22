using System;

namespace DiamondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if a valid argument is provided
            if (args.Length > 0 && char.TryParse(args[0], out char inputChar) && char.IsLetter(inputChar))
            {
                // Print the generated diamond to the console
                Console.WriteLine(DiamondGenerator.Generate(char.ToUpper(inputChar)));
            }
            else
            {
                // Print error message if input is invalid
                Console.WriteLine("Please provide a valid letter.");
            }
        }
    }
}
