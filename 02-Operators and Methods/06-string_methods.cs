using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string fullName = "Rajendran";
        
        
        fullName = fullName.ToUpper();
        Console.WriteLine("Name : " + fullName);
        
        fullName = fullName.ToLower();
        Console.WriteLine("Name : "+fullName);
         
        string phoneNumber = "123-456-789";
        
        phoneNumber = phoneNumber.Replace("-","/");
        Console.WriteLine("Phone no : " + phoneNumber);
    }
}

/*

OUTPUT : 

Name : RAJENDRAN
Name : rajendran
Phone no : 123/456/789

*/ 