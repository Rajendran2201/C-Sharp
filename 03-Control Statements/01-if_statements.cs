using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
      Console.Write("Enter your age : ");
      int age = Convert.ToInt32(Console.ReadLine());
      
      if(age>=18){
          Console.WriteLine("You're eligible for voting !");
      }else{
          Console.WriteLine("Sorry, You're not eligible for voting !");
      }
      
    }
}


/*


OUTPUT : 

Enter your age : 12
Sorry, You're not eligible for voting !

*/ 