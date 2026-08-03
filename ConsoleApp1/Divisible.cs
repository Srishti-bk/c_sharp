//Check whether a number is divisible by 5.
using System;
class Divisible
{
    public void Check()
    {
        int num;
        Console.WriteLine("Enter a number:");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0)
        {
            Console.WriteLine($"{num} is divisible by 5");
        }

        else
        {
            Console.WriteLine($"{num} is not divisible by 5");
        }
    }
}