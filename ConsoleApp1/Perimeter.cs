//Store the length and breadth of a rectangle and calculate the perimeter
using System;
class Perimeter
{
    public void Calculate()
    {
        int length=15;
        int breadth=14;
        int perimeter=2*(length+breadth);

        Console.WriteLine($"The perimeter of rectangle having {length} and {breadth} is {perimeter} ");

    }
}