using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello welcome to my random number guess game!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 10);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("lower");
            }
        } while (guess != number);

        Console.WriteLine("Congratulations! You guessed the number!");
    }
}
