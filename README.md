using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter first Number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second Number"); 
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a);
        
        if (a>b)
        Console.WriteLine("a is greater than b");
        else if (b>a)
        Console.WriteLine("b is greater than a");
        else
        Console.WriteLine("a is equal to b");
    }
}