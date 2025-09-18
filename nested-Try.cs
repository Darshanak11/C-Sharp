using System;
class Program
{
    static void Main()
    {
       
        try
        {
            
            //nested try
            try
            {
                Console.WriteLine("enter a Number");
                int Num = Convert.ToInt32(Console.ReadLine());
                int dividByZero = 6 / Num;
                Console.WriteLine(dividByZero);
            }
            //inner catch block
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("inner catch is excecuted");
            }
        }
        //outer catch block
        catch (DivideByZeroException)
        {
            Console.WriteLine("outer catch is executed");
        }
    }
}
