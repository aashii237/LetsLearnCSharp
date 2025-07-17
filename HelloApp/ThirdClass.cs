using System;

public class Third
{
    public void Months()
    {
        
        Console.WriteLine("Enter a month (e.g., 'Jan' or '1'):");

            string? input = Console.ReadLine()?.Trim().ToLower();

            if (input == "1" || input == "jan")
                Console.WriteLine("Month is January");
            else if (input == "2" || input == "feb")
                Console.WriteLine("Month is February");
            else if (input == "3" || input == "mar")
                Console.WriteLine("Month is March");
            else if (input == "4" || input == "apr")
                Console.WriteLine("Month is April");
            else if (input == "5" || input == "may")
                Console.WriteLine("Month is May");
            else if (input == "6" || input == "jun")
                Console.WriteLine("Month is June");
            else if (input == "7" || input == "jul")
                Console.WriteLine("Month is July");
            else if (input == "8" || input == "aug")
                Console.WriteLine("Month is August");
            else if (input == "9" || input == "sep")
                Console.WriteLine("Month is September");
            else if (input == "10" || input == "oct")
                Console.WriteLine("Month is October");
            else if (input == "11" || input == "nov")
                Console.WriteLine("Month is November");
            else if (input == "12" || input == "dec")
                Console.WriteLine("Month is December");
            else
                Console.WriteLine("Invalid month input.");
        }
    }