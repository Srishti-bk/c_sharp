// 4. Write a program to find the smaller of two numbers.
using System;
class Smallernum
{
    public void Check()
    {
        int a;
        Console.WriteLine("Enter a number a :");
        a=Convert.ToInt32(Console.ReadLine());

        int b;
        Console.WriteLine("Enter a number b:");
        b=Convert.ToInt32(Console.ReadLine());

        if (a < b)
        {
            Console.WriteLine($"{a} is smaller  than {b}");
        }
        else if (b < a)
        {
            Console.WriteLine($"{b} is smaller than {a}");
        }
    }
}
