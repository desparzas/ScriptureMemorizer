﻿class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only Son");

        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        while (!scripture.AllWordsHidden())
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
        }

        Console.WriteLine("All words are hidden. End Program.");
    }
}