using System;

namespace Develop03
{
    ///<summary>
    /// The responsibility of a Words is to manipulate individual words in the scripture.
    ///</summary>
    public class Words
    {
        Scripture text = new Scripture();
        string fullText;
        string[] textParts;

        string _words;

        public Words()
        {
            fullText = text.GetScripture();
        }

        public string SplitWords()
        {
            textParts = fullText.Split("|");
           
           return textParts[1];
        }
        public string GetWords()
        {
            _words = SplitWords();
            return _words;
        }
        public string HideWord()
        {
            Console.WriteLine("Press enter to hide a word, and press any other key to exit:");

            string[] words = _words.Split(' ');
            bool[] hiddenWords = new bool[words.Length];

            while (true)
            {
                // Check if all words are already hidden
                if (hiddenWords.All(isHidden => isHidden))
                {
                    Console.WriteLine("All words are hidden.");
                    break;
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    // Find a random word index to hide
                    Random random = new Random();
                    int wordIndex;

                    do
                    {
                        wordIndex = random.Next(words.Length);
                    } while (hiddenWords[wordIndex]);

                    // Replace the word with blank spaces
                    words[wordIndex] = new string(' ', words[wordIndex].Length);

                    // Mark the word as hidden
                    hiddenWords[wordIndex] = true;

                    // Join the words back to form the updated scripture text
                    _words = string.Join(" ", words);

                    // Clear the console screen
                    Console.Clear();

                    // Display the updated scripture text
                    Console.WriteLine(_words);
                }
                else
                {
                    break;
                }
            }

            return _words;
        }
    }
}