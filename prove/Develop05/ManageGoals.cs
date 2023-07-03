using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public class ManageGoals
{
    // Attributes
    private List<Goal> _goals;
    private int _totalPoints;

    // Constructors
    public ManageGoals()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    // Properties
    public int totalPoints
    {
        get { return _totalPoints; }
        set { _totalPoints = value; }
    }

    // Methods
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void ListGoals()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index++;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplish?  ");
        int select = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _goals[select];
        int goalPoints = selectedGoal.points;
        _totalPoints += goalPoints;

        selectedGoal.RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {_totalPoints} points! ***\n");
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(_totalPoints);
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // Read the first line of the text file for total stored points
            _totalPoints = int.Parse(readText[0]);

            // Skip the first line of the text file to read the goals
            readText = readText.Skip(1).ToArray();

            // Clear existing goals
            _goals.Clear();

            // Loop through text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool isCompleted = bool.Parse(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, isCompleted);
                    AddGoal(sGoal);
                }
                else if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, isCompleted);
                    AddGoal(eGoal);
                }
                else if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, isCompleted, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
            }
        }
    }
}

}