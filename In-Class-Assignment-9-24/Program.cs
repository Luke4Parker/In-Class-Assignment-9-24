using System;

namespace In_Class_Assignment_9_24
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dollar amount and I will change it into coins for you: ");
            string dollarInput = Console.ReadLine();
            
            decimal dollars = decimal.Parse(dollarInput);

            decimal quarters = (dollars - (dollars % .25m)) / .25m;
            decimal remainder = dollars - (quarters * .25m);
            decimal dimes = (remainder - (remainder % .10m)) / .10m;
            remainder -= dimes * .10m;
            decimal nickels = (remainder - (remainder % .05m)) / .05m;
            remainder -= nickels * .05m;
            decimal pennies = (remainder - (remainder % .01m)) / .01m;
            remainder -= pennies * .01m;

            Console.WriteLine("Quarter: " + quarters + " | Dimes: " + dimes + " | Nickels: " + nickels + " | Pennies: " + pennies);
            
        }
    }
}
