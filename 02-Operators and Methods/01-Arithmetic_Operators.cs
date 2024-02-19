using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int friends = 5;
       Console.WriteLine(friends);
       
       friends += 2;
       Console.WriteLine(friends);
       
       friends++;
       Console.WriteLine(friends);
       
       friends *= 2;
       Console.WriteLine(friends);
       
       friends /=2;
       Console.WriteLine(friends);
       
    }
}

/*


OUTPUT: 

5
7
8
16
8

*/ 