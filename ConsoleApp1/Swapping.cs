//Swap the values of two variables using a third variable.
using System;
class Swapping{
    public void Swap()
    {
        int a=10;
        int b=20;
        int c;

        //before swapping
        Console.WriteLine($"The value of a is {a} and b is {b}");

        c=a;
        a=b;
        b=c;

        //after swapping
        Console.WriteLine($"The value of a is {a} and b is {b}");



    }
}
