using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public class MainMenu
{
    // Attributes
    private string _menu = $@"
    Main Menu Options
    ===========================================
    Please select one of the following options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Goal Event
    6. Quit
    ===========================================
    Select an option from the menu:  ";

    // Methods
    public int UserChoice()
    {
        Console.Write(_menu);

        string userInput = Console.ReadLine();
        int userChoice = 0;

        try
        {
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
        }

        return userChoice;
    }
}
}