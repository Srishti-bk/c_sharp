// 9. Greatest of Three Numbers
//Find the largest among three numbers using nested if.
using System;
class Greatestof3
{
    public void check()
    {
        int a;
        Console.WriteLine("Enter a number a:");
        a = Convert.ToInt32(Console.ReadLine());

        int b;
        Console.WriteLine("Enter a number b:");
        b = Convert.ToInt32(Console.ReadLine());

         int c;
        Console.WriteLine("Enter a number c:");
        c = Convert.ToInt32(Console.ReadLine());

        if (a > b && b > c)
        {
            Console.WriteLine($"{a} is larger than {b} and {b} is larger than {c}");
            
        }
        else if (a < b && a < b)
        {
            Console.WriteLine($"{a} is smaller than {b} and {b} is smaller than {c}");
        }
        

    }
}