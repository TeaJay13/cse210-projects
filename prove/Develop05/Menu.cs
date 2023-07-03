using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public class GoalMenu
{
    // Attributes
    private string _menu = $@"
    Goal Menu Options
    ===========================================
    The Types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
    4. Back to Main Menu
    ===========================================
    What type of goal would you like to create?  ";

    // Methods
    public int GoalChoice()
    {
        Console.Write(_menu);

        string goalInput = Console.ReadLine();
        int goalChoice = 0;

        try
        {
            goalChoice = int.Parse(goalInput);
        }
        catch (FormatException)
        {
            goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
        }

        return goalChoice;
    }
}
}