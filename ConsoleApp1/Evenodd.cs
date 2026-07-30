//. Write a C# program that checks whether a given integer is even or odd.
using System;
class Evenodd
{
    public void Check()
    {
        int num;
        Console.WriteLine("Enter a number:");
        num=Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is even");
        }
        else
        {
            Console.WriteLine($"{num} is odd");
        }
    }
}