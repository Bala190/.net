using System;


public class CustomDivideByZeroException : Exception
{
    public CustomDivideByZeroException() : base("Custom DivideByZeroException: Cannot divide by zero!")
    {
       
    }
}

class Program
{
    static void Main()
    {
        try
        {
            int result = DivideNumbers(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (CustomDivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadLine();
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new CustomDivideByZeroException();
        }

        return numerator / denominator;
    }
}
