using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
   
    Console.Write("What's the temperature outside ?");
    double temp = Convert.ToDouble(Console.ReadLine());
    
    // && - and operator 
    if (temp >= 10 && temp <= 25){
        Console.Write("The weather is mild");
    }else if (temp >25 && temp <=35){
        Console.Write("The weather is hot");
    }else{
        Console.Write("Too hot");
    }
      
    }
}

/*

OUTPUT : 

What's the temperature outside ? 45
Too hot

*/