//## 1. Positive, Negative or ZeroWrite a program to input a number and determine whether it is:Positive, Negative,Zero
using System;
class Numbercheck
{
    public void Check()
    {
        int num;
        Console.WriteLine($"Enter a number :");

        num=Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine($"{num} is positive");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is negative");
        }
        else
        {
            Console.WriteLine($"{num} is zero");
        }
    }
}