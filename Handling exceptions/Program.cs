using System;

class Program
{
    static void Main()
    {
        // Example: Division by zero
        int numerator = 10;
        int denominator = 0;

        try
        {
            // Attempting to divide by zero
            int result = DivideNumbers(numerator, denominator);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block always executes, whether there's an exception or not.");
        }

        
        Console.WriteLine("Program continues executing...");

        Console.ReadLine();
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
