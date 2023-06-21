using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Listing : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing(int duration) : base()
        {
            SetDuration(duration);
        }

        public void StartListingActivity()
        {
            string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            Console.WriteLine(description);

            Console.WriteLine("Prepare to begin the Listing Activity");
            Thread.Sleep(1000);
            Console.WriteLine("Start listing");

            int duration = GetDuration();
            Random random = new Random();
            int itemCount = 0;
            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                string prompt = prompts[random.Next(prompts.Count)];

                Console.WriteLine(prompt);
                AnimateCountdown(1, 1000);

                Console.WriteLine("Start listing items:");

                while ((DateTime.Now - startTime).TotalSeconds < duration)
                {
                    string item = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(item))
                    {
                        Console.WriteLine("Enter a valid input.");
                        continue;
                    }

                    itemCount++;
                }
            }
            
            Console.WriteLine($"You listed a total of {itemCount} items.");
        }

        private void AnimateCountdown(int iterations, int delay)
        {
            int[] nums = { 4, 3, 2, 1 };

            for (int i = 0; i < iterations; i++)
            {
                foreach (int num in nums)
                {
                    Console.Write(num);
                    Thread.Sleep(delay);
                    Console.Write("\b \b");
                }
            }
        }
    }
}
