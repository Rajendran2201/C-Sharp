using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
     // convert a string into char 
     string str = "R"; 
     char c = Convert.ToChar(str); 
     Console.WriteLine("The value of c is " + c);
     Console.WriteLine("The data type of c is " + c.GetType());
     
    }
}


/*

OUTPUT : 

The value of c is R
The data type of c is System.Char


*/ 