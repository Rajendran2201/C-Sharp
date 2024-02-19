using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    
         Random random = new Random(); 
       
         int num = random.Next(1,7);    // gives random no as 1,2,3,4,5,6
         Console.WriteLine(num);
         
         double n = random.NextDouble();
         Console.WriteLine(n);
    }
}

/*

OUTPUT : 

6
0.826754541055651

*/
