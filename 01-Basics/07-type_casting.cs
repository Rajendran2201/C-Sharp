using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
      // type casting - converting a vlue into a different data type 
      // It is useful when we accept user input (string) 
      // Different datatypes can do different things 
      
      double x = 3.3123;
      int y = Convert.ToInt32(x);
      Console.WriteLine("The value of x is : " + x);
      Console.WriteLine("The value of y is : " + y);
      
      Console.WriteLine("The data type of x is " + x.GetType());
      Console.WriteLine("The data type of y is " + y.GetType());
      
      
      int c = 32; 
      double d = Convert.ToDouble(c); 
      Console.WriteLine("The value of c is : " + c);
      Console.WriteLine("The value of d is : " + d);    // double with no decimal points will look like int 
      
      int e = 232; 
      string f = Convert.ToString(e);
      Console.WriteLine("The value of e is : " + e);
      Console.WriteLine("The value of f is : " + f); 
      Console.WriteLine("The data type of e is " + e.GetType());
      Console.WriteLine("The data type of f is " + f.GetType());
      
    }
}

/*

OUTPUT : 


The value of x is : 3.3123
The value of y is : 3
The data type of x is System.Double
The data type of y is System.Int32
The value of c is : 32
The value of d is : 32
The value of e is : 232
The value of f is : 232
The data type of e is System.Int32
The data type of f is System.String


*/ 