using System;
using System.Threading;

namespace Develop04
{
    public class Breathing : Activity
    {
        public Breathing(int duration) : base()
        {
            SetDuration(duration);
        }

        public void StartBreathingActivity()
        {
            string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            Console.WriteLine(description);

            Console.WriteLine("Prepare to begin the Breathing Activity");
            Thread.Sleep(1000); 

            Console.WriteLine("Start breathing in and out slowly");
            Thread.Sleep(1000);

            int duration = GetDuration();
            int breathCount = 0;

            while (duration > 0)
            {
                Console.WriteLine("Breathe in");
                AnimateEllipsis(4, 250); 
                Console.WriteLine();
                Thread.Sleep(1000);
                duration-= 2;

                Console.WriteLine("Breathe out");
                AnimateEllipsis(4, 250);
                Console.WriteLine();
                Thread.Sleep(1000); 
                duration-= 2;

                breathCount++;
            }
        }

        private void AnimateEllipsis(int iterations, int delay)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write(".");
                Thread.Sleep(delay); // Pause for the specified delay
            }
        }
    }
}

