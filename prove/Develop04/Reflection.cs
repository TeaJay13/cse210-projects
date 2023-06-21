using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Reflection : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private List<string> spinnerFrames = new List<string>
        {
            "|",
            "/",
            "-",
            "\\"
        };

        public Reflection(int duration) : base()
        {
            SetDuration(duration);
        }

        public void StartReflectionActivity()
        {
            string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Console.WriteLine(description);

            Console.WriteLine("Prepare to begin the Reflection Activity");
            Thread.Sleep(1000);
            Console.WriteLine("Start reflecting");
            Thread.Sleep(1000);

            int duration = GetDuration();
            int seconds = 0;
            Random random = new Random();

            while (seconds < duration)
            {
                string prompt = prompts[random.Next(prompts.Count)];
                string question = questions[random.Next(questions.Count)];

                Console.WriteLine(prompt);
                Thread.Sleep(1000);

                Console.WriteLine(question);
                AnimateSpinner(1, 250);
                Thread.Sleep(1000);

                seconds += 3; // Increment the current seconds by 3 (prompt + question time)
            }
        }

        private void AnimateSpinner(int iterations, int delay)
        {

            for (int i = 0; i < iterations; i++)
            {
                foreach (string frame in spinnerFrames)
                {
                    Console.Write(frame);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
            }
        }
    }
}
