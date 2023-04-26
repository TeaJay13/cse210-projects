using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello welcome to number list creator");

        List<int> numbers = new List<int>();
        int number = -1;

        while(number != 0)
        {
            Console.WriteLine("Enter your number (enter 0 when finished) enter here ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
        }

        int sum = 0;

        foreach(int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach(int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
