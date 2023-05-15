using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
   public class Program
    {
        public static Journal journal ;
        static void Main(string[] args)
        {
            journal = new Journal();
            ShowMenu();
        }
        
         static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        DisplayJournal();
                        break;
                    case "3":
                        SaveJournalToFile();
                        break;
                    case "4":
                        LoadJournalFromFile();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        
        static void WriteNewEntry()
        {
            Entry NewEntry = new Entry();
            Prompt promptInstance = new Prompt();
            string prompt = promptInstance.SelectPrompt();
            Console.WriteLine(prompt);
            string response  = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            NewEntry.StoreDate(date);
            NewEntry.StorePrompt(prompt);
            NewEntry.StoreResponse(response);
            journal.StoreEntry(NewEntry);
            Console.WriteLine("New entry added to the journal.");
        }
        static void DisplayJournal()
        {
            if (journal.GetEntries().Count == 0)
            {
                Console.WriteLine("The journal is empty.");
            }
            else
            {
                Console.WriteLine("Journal Entries:");
                foreach (Entry entry in journal.GetEntries())
                {
                    Console.WriteLine($"[{entry.GetDate()}] {entry.GetPrompt()}: {entry.GetResponse()}");
                }
            }
        }
        static void SaveJournalToFile()
        {
            Console.WriteLine("Enter a filename to save the journal to:");
            string filename = Console.ReadLine();

                using (StreamWriter file = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal.entries)
                    {
                        file.WriteLine($"{entry.GetDate()}~{entry.GetPrompt()}~{entry.GetResponse()}");
                    }
                }

                Console.WriteLine($"Journal saved to file {filename}");
            
        }
        static void LoadJournalFromFile()
        {
            Console.Write("Enter the file path to load the journal from: ");
            string filePath = Console.ReadLine();
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
            }
            else
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                   string[] lines = File.ReadAllLines(filePath);
                     foreach (string line in lines)
                    {
                        string[] values = line.Split('~');
                        Entry entry = new Entry();
                        entry.StoreDate(values[0]);
                        entry.StorePrompt(values[1]);
                        entry.StoreResponse(values[2]);
                        journal.StoreEntry(entry);
                    }
                }

                Console.WriteLine($"Journal loaded from file {filePath}");
            }
        }
        

        
    }       
    }
}

