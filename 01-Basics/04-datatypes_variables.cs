using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        
            There are two steps in using variables 
            
            1. Declaration 
            2. Initialisation 
                    
        */
        // int - whole numbers 
        int x;  // Declaration 
        x = 2;  // Initialisation 
        Console.WriteLine("The value of x is " + x);
        
        int a = 12; // Declaration with Initialisation 
        Console.WriteLine("The value of a is " + a);
        
        
        // double - numbers with decimal / floating points 
        double y; 
        y = 3.128678;
        Console.WriteLine("The value of y is " + y +"\nThis is of double data type");
        
        // bool is used to store logical values - true or false
        bool alive = true; 
        Console.WriteLine("Are you alive ? "+alive);
        
        
        // char is used to store a single character 
        char symbol = '$';
        Console.WriteLine("The symbol for money is " + symbol);
        
        
    }
}

/*

OUTPUT : 


The value of x is 2
The value of a is 12
The value of y is 3.128678
This is of double data type
Are you alive ? True
The symbol for money is $


*/