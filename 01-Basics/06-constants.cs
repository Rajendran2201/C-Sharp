using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       // constants - immutable values which are known at compile time and do not change for the life of the program 
             double pi_sample = 3.14159;
             pi_sample = 23;
             Console.WriteLine("The value of pi is " + pi_sample);
           
             const double pi = 3.14159;
             Console.WriteLine("The value of pi is " + pi);
           
      
    }
}

/*

OUTPUT : 

The value of pi is 23
The value of pi is 3.14159

*/
