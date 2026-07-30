//Input two integers and display the larger one.
using System;
class Largernum
{
    public void Check()
    {
        int a;
        Console.WriteLine("Enter a number a :");
        a=Convert.ToInt32(Console.ReadLine());

        int b;
        Console.WriteLine("Enter a number b:");
        b=Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{a} is larger than {b}");
        }
        else if (b > a)
        {
            Console.WriteLine($"{b} is larger than {a}");
        }
    }
}