using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>();
    int chosen = -1;
    while (chosen != 0)
        {
        Console.Write("Enter a number (0 to quit): ");   
        string userResponse = Console.ReadLine();
        chosen = int.Parse(userResponse);
        if (chosen != 0)
            {
            numbers.Add(chosen);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
            {
            sum += number;
            }

        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
            max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}