using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulating a situation where an exception might occur
            int result = DivideNumbers(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Code in the finally block will always run, whether an exception occurred or not
            Console.WriteLine("Finally block always executes, regardless of exceptions.");
        }

        // Rest of the program continues executing after handling the exception
        Console.WriteLine("Program continues executing...");

        Console.ReadLine();
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            // Throwing a DivideByZeroException
            throw new DivideByZeroException("Cannot divide by zero!");
        }

        return numerator / denominator;
    }
}

