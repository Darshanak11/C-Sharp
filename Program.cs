using System;
class Program

{ 
    static void Main() 
    {
        Console.WriteLine("enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, temp = num;

        while(temp>0)
        {
            int digit = temp % 10;
            sum += digit*digit*digit;
            temp /= 10;
        }
        if (sum == num)
        {
            Console.WriteLine("armstrong");
        }
        else
        {
            Console.WriteLine("not armstrong");
        }
    }
    

}