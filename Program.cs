﻿using System;
public abstract class Shape
{
    public abstract void CalculatedArea();
}
class Circle : Shape
{
    private int r;
    public void Read(int a)
    {
         r = a;
    }
    public override void CalculatedArea();
     {
        float area = 3.14f * r * r;
        Console.WriteLine("area of the circle"+area);
    }
}

class program
{
    static void Main()
    {
        Circle c=new Circle();
        Console.WriteLine("enter the radius");
        int a= Convert.ToInt32(Console.ReadLine());
        c.Read(a);
        c.CalculatedArea;
    }
}

 
    

