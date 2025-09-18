using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Results: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: please enter the vaild numbers only");
        }
        finally
        {
            Console.WriteLine("Thank you for using the program");
        }
    }
}
