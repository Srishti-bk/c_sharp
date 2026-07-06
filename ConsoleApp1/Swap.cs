//Swap two variables without using a third variable.
using System;
class Swap
{
    public void Swapping()
    {
        int a=10;
        int b=20;
         //Before swapping
         Console.WriteLine($"The value of a is {a} and b is {b}");
           
           a=a+10;
           b=b-10;

           //after swapping
           Console.WriteLine($"The value of a is {a} and b is {b}");
        
    }
}