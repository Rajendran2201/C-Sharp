using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter side-a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter side-b : ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double c = Math.Sqrt((a*a) + (b*b));
        Console.Write("The value of third side is " + c);
    }
}

/*

OUTPUT : 


Enter side-a : 3
Enter side-b : 4
The value of third side is 5

*/