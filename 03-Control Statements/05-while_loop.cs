using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
   
    Console.WriteLine("Enter your name : ");
    string name = Console.ReadLine(); 
    
    while(name == ""){
        
         Console.Write("Enter your name : ");
         name = Console.ReadLine();
         
    }
    
    Console.WriteLine("Hello," + name);
      
    }
}

/*


OUTPUT : 


Enter your name : 
Enter your name : 
Enter your name : 
Enter your name : 
Enter your name : Raj
Hello,Raj

*/