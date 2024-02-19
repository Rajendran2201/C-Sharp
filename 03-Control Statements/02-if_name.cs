using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
    // ask the user for their name 
   
    Console.Write("Enter your name : "); 
    string name = Console.ReadLine(); 
    
    if(name == "Raj"){
        Console.WriteLine("You are Raj!");
    }else{
        Console.WriteLine("You are somebody else!");
    }
      
    }
}


/* 


OUTPUT : 

Enter your name : Raj
You are Raj!


Enter your name : furook
You are somebody else!

*/ 