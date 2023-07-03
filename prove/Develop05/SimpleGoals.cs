using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public class SimpleGoal: Goal
    {
      private bool _isCompleted;


      public SimpleGoal(string type, string name, string description,int score) : base(type, name, description, score)
      {
        _isCompleted = false;
      }

      public SimpleGoal(string type, string name, string description, int points, bool isCompleted) : base(type, name, description, points)
    {
        _isCompleted = isCompleted;
    }

         public override void ListGoal(int i)
    {
        if (!_isCompleted)
            Console.WriteLine($"{i}. [ ] {name} ({description})");
        else
            Console.WriteLine($"{i}. [X] {name} ({description})");
    }

    public override string SaveGoal()
    {
        return $"{type}; {name}; {description}; {points}; {_isCompleted}";
    }

    public override string LoadGoal()
    {
        return $"{type}; {name}; {description}; {points}; {_isCompleted}";
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }
    }
        
       


}