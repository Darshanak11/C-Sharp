using System;

class program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Result = Num1 / Num2;
            Console.WriteLine("result" + Result);
        }
    }
        Catch (DivideByZeroException)
    {
        Console.WriteLine("Error: cannot divided by Zero);
    }
    Catch (FormatException)
    {
        Console.WriteLine("Erroe : please enter valid numbers only);
    }
}
