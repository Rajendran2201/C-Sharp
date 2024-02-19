using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
    // print the day of the week 
    
    Console.Write("Enter the day number : "); 
    int dayNum = Convert.ToInt32(Console.ReadLine());
    
    switch(dayNum){
        case 1:
            Console.Write("Sunday");
            break;
        case 2:
            Console.Write("Monday");
            break;
        case 3:
            Console.Write("Tuesday");
            break;
        case 4:
            Console.Write("Wednesday");
            break;
        case 5:
            Console.Write("Thursday");
            break;
        case 6:
            Console.Write("Friday");
            break;
        case 7:
            Console.Write("Saturday");
            break;
        default: 
            Console.Write("Invalid Input");
            break;
    }
    
   
      
    }
}


/*

OUTPUT : 

Enter the day number : 40
Invalid Input


*/
