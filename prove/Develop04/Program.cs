using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                // Create an instance and fill up the variables with activity selection input
                Activity exercise = new Activity();
                int duration = exercise.AskForDuration();
                exercise.SetDuration(duration);
                string activity = exercise.AskForActivity();
                exercise.SetActivity(activity);

                string openingMsg = exercise.CreateOpeningMsg(activity, duration);
                exercise.SetOpeningMsg(activity);

                string endingMsg = exercise.CreateEndingMsg(activity);
                exercise.SetEndingMsg(activity);

                // Use activity to run the activity from child class
                if (activity == "breathing")
                {
                    Console.WriteLine(openingMsg);
                    Breathing breathingActivity = new Breathing(duration);
                    breathingActivity.StartBreathingActivity();
                    Console.WriteLine(endingMsg);
                }
                else if (activity == "reflection")
                {
                    Console.WriteLine(openingMsg);
                    Reflection reflectionActivity = new Reflection(duration);
                    reflectionActivity.StartReflectionActivity();
                    Console.WriteLine(endingMsg);
                }
                else if (activity == "listing")
                {
                    Console.WriteLine(openingMsg);
                    Listing listingActivity = new Listing(duration);
                    listingActivity.StartListingActivity();
                    Console.WriteLine(endingMsg);
                }
                else
                {
                    Console.WriteLine("Invalid activity selection. Please try again.");
                }

                Console.WriteLine("Do you want to go again (y/n):");
                string response = Console.ReadLine();
                if (response != "y")
                {
                    repeat = false;
                }
            }
        }
    }
}
