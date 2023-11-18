using System;

class Program
{
    static void Main()
    {
        // Example: Catching a general exception
        try
        {
            // Code that might cause an exception
            int result = PerformOperation();
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // Rest of the program continues executing after handling the exception
        Console.WriteLine("Program continues executing...");

        Console.ReadLine();
    }

    static int PerformOperation()
    {
       
        return 20 / 0;
    }
}
