using System;

class Program
{
    class Person
    {
        public string Name;
        public void PrintName()
        {
            Console.WriteLine("Name: " + Name.ToUpper());
        }
    }

    static void Main()
    {
        Console.Write("Enter name (leave blank to cause error): ");
        string input = Console.ReadLine();

        Person person = new Person();

        try
        {
            if (string.IsNullOrEmpty(input))
            {
                // Name not assigned, calling method causes NullReferenceException
                person.Name = null;
            }
            else
            {
                person.Name = input;
            }

            person.PrintName();
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error: Name is null, cannot print.");
        }
    }
}
