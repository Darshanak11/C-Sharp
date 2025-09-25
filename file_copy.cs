using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = @"C:\Users\Student\OneDrive\Desktop\darshana k\c#\source.txt";
        string destPath = @"C:\Users\Student\OneDrive\Desktop\darshana k\c#\destination.txt";

        string content = File.ReadAllText(sourcePath);
        File.WriteAllText(destPath, content);

        Console.WriteLine("File copied successfully.");
    }
}
