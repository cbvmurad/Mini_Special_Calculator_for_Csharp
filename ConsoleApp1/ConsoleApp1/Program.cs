using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. Welcome to mini calculator. This program can perform various math operations. Choose the number command");

        while (true)
        {
            DisplayInfo();
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    FindMaximumAndMinimumValue();
                    break;
                case 2:
                    FindFactorialValue();
                    break;
                case 3:
                    FindAverageValue();
                    break;
                case 4:
                    FindSquareRootValue();
                    break;
                case 5:
                    FindSquareValue();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayInfo()
    {
        Console.WriteLine("\nChoose 1 command for find maximum and minimum");
        Console.WriteLine("Choose 2 command for find factorial");
        Console.WriteLine("Choose 3 command for find average");
        Console.WriteLine("Choose 4 command for find square root");
        Console.WriteLine("Choose 5 command for find square");
        Console.WriteLine("Choose 0 command for exit this program");
    }

    static void FindMaximumAndMinimumValue()
    {
        Console.Write("Enter numbers separated by spaces: ");
        try
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            Console.WriteLine($"The maximum value is {numbers.Max()}\nThe minimum value is {numbers.Min()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers separated by spaces.");
        }
    }

    static void FindFactorialValue()
    {
        Console.Write("Which number do you want to find factorial? Write number please: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.WriteLine("Please enter a valid non-negative number.");
            return;
        }

        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"The factorial value is: {factorial}");
    }

    static void FindAverageValue()
    {
        Console.Write("Enter numbers separated by spaces: ");
        try
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            if (numbers.Length == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            Console.WriteLine($"The average value is: {numbers.Average()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers separated by spaces.");
        }
    }

    static void FindSquareRootValue()
    {
        Console.Write("Which number do you want to find square root? Write number please: ");
        if (!double.TryParse(Console.ReadLine(), out double number) || number < 0)
        {
            Console.WriteLine("Please enter a valid non-negative number.");
            return;
        }

        Console.WriteLine($"The square root value is: {Math.Sqrt(number)}");
    }

    static void FindSquareValue()
    {
        Console.Write("Which number do you want to find square? Write number please: ");
        if (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Console.WriteLine($"The square value is: {Math.Pow(number, 2)}");
    }
}