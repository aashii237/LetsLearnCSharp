using System;

public class Second
{
    public void Method()
    {
        
        Console.WriteLine("Enter first Number");
        int Num = int.Parse(Console.ReadLine());
        
        if (Num==0)
        Console.WriteLine("Number is Zero");
        else if (Num%2!=0)
        Console.WriteLine("Number is odd");
        else
        Console.WriteLine("Number is even");
    }
}