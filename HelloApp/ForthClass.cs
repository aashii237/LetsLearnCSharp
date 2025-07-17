using System;

public class Forth
{
    public void Numbers()
    {     
        Console.WriteLine("Enter any number");  
        int n = int.Parse(Console.ReadLine()); 

        for(int i=1; i<=n; i++)
        {
            Console.WriteLine(i);
        }

    }
}