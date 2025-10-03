using System;

namespace ScriptureMemorizer
{
    internal static class Program
    {
        private static void Main()
        {
            var reference = new Reference("Proverbs", 3, 5, 6);
            var text =
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths.";

            var scripture = new Scripture(reference, text);
            var rng = new Random();

            Console.Clear();
            Console.WriteLine(scripture.Render());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words, or type quit.");

            while (true)
            {
                string input = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
                if (input == "quit") break;

                scripture.HideRandomWords(3, rng);
                Console.Clear();
                Console.WriteLine(scripture.Render());

                if (scripture.AllWordsHidden) break;

                Console.WriteLine();
                Console.WriteLine("Press Enter to hide more, or type quit.");
            }
        }
    }
}