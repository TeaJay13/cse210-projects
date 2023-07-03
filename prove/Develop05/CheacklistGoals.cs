using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public class ChecklistGoal : Goal
{
    // Attributes
    private int _numberTimes;
    private int _bonusPoints;
    private bool _isCompleted;
    private int _count;

    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints)
        : base(type, name, description, points)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _isCompleted = false;
        _count = 0;
    }

    public ChecklistGoal(string type, string name, string description, int points, bool isCompleted, int numberTimes, int bonusPoints, int count)
        : base(type, name, description, points)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _isCompleted = isCompleted;
        _count = count;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (!_isCompleted)
            Console.WriteLine($"{i}. [ ] {name} ({description})  --  Currently Completed: {_count}/{_numberTimes}");
        else
            Console.WriteLine($"{i}. [X] {name} ({description})  --  Completed: {_count}/{_numberTimes}");
    }

    public override string SaveGoal()
    {
        return $"{type}; {name}; {description}; {points}; {_isCompleted}; {_numberTimes}; {_bonusPoints}; {_count}";
    }

    public override string LoadGoal()
    {
        return $"{type}; {name}; {description}; {points}; {_isCompleted}; {_numberTimes}; {_bonusPoints}; {_count}";
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        _count++;
        if (_count == _numberTimes)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You have earned {points + _bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
    }
}
}
