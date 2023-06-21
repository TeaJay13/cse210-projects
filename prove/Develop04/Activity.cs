using System;

namespace Develop04
{
    public class Activity
    {
        
        private int _duration;
        private string _activity;
        private string _openingMsg;
        private string _endingMsg;

        public int GetDuration()
        {
            return _duration;
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        public string GetActivity()
        {
            return _activity;
        }

        public void SetActivity(string activity)
        {
            _activity = activity;
        }

        public string GetOpeningMsg()
        {
            return _openingMsg;
        }

        public void SetOpeningMsg(string openingMsg)
        {
            _openingMsg = openingMsg;
        }

         public string GetEndingMsg()
        {
            return _endingMsg;
        }

        public void SetEndingMsg(string endingMsg)
        {
            _endingMsg = endingMsg;
        }

    public int AskForDuration()
    {
        while (true)
        {
            Console.WriteLine("Enter the desired duration in seconds:");

            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine($"Duration set to: {duration} seconds");
                return duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value.");
            }
        }
    }

   public string AskForActivity()
        {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                string selection = " ";

                switch (choice)
                {
                    case "1":
                        selection = "breathing";
                        break;
                    case "2":
                        selection = "reflection";
                        break;
                    case "3":
                        selection = "listing";
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                } 
                return selection;   
        }
    public string CreateOpeningMsg(string activity, int time)
    {
        string Omessage  = "";
        Omessage = $"Welcome to the {activity} activity! for {time} seconds";
        return Omessage;
    }

     public string CreateEndingMsg(string activity)
    {
        string Emessage  = "";
        Emessage = $"Thank you for participating in the {activity} activity!";
        return Emessage;
    }
        
    }
}