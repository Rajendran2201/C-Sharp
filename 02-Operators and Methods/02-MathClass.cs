
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     
     double a = 3;
     double x = Math.Pow(a,2);
       
    Console.WriteLine("The value of " + a + " raised to the power of 2 is "+ x);
    
    
    double y = Math.Sqrt(x);
    Console.WriteLine("The square root of 9 is" + y); 
    
    int num = -3;
    int z = Math.Abs(num);
    Console.WriteLine("The absolute value of -3 is " + z);
    
    double s = 32.2; 
    Console.WriteLine("The rounded value of s is " + Math.Round(s));
    Console.WriteLine("The ceil value of s is " + Math.Ceiling(s));
    Console.WriteLine("The floor value of s is " + Math.Floor(s));
}
}

/*


OUTPUT : 

The value of 3 raised to the power of 2 is 9
The square root of 9 is3
The absolute value of -3 is 3
The rounded value of s is 32
The ceil value of s is 33
The floor value of s is 32


*/