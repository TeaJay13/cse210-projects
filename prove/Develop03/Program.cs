using System;
using System.Collections.Generic;
using System.IO;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scripture scripturetest = new Scripture();
            // string scriptureTexttest = scripturetest.GetScripture();
            // Console.WriteLine(scriptureTexttest);

            // Reference test = new Reference();
            // string refTest = test.GetRefrence();
            // Console.WriteLine(refTest);

            // Words test2 = new Words();
            // string wordtest = test2.GetWords();
            // Console.WriteLine(wordtest);

            // Create instances of the classes
            Scripture scripture = new Scripture();
            Reference reference = new Reference();
            Words words = new Words();

            // Retrieve the scripture, reference, and words
            string scriptureText = scripture.GetScripture();
            string referenceText = reference.GetRefrence();
            string wordsText = words.GetWords();

            // Print the scripture, reference, and words
            Console.WriteLine($"Scripture:{scriptureText}");
            Console.WriteLine($"Reference:{referenceText}");
            Console.WriteLine($"Words:{wordsText}");

            // Hide words interactively until the user chooses to exit
            string hiddenWords = words.HideWord();
            Console.WriteLine($"\nScripture:{referenceText}{wordsText}");
            
        }
    }
}