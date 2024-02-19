using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your name : ");
        string name = Console.ReadLine();
        
        Console.Write("What's your age ? "); 
        int age = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine("Hello, " + name);
        Console.WriteLine("Age: " + age);
        
    }
}


/*

OUTPUT : 

Enter Your name : Raj
What's your age ? 19
Hello, Raj
Age: 19

*/