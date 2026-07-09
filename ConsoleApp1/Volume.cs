//16.Store the dimensions of a room and calculate its volume.
using System;
class Volume
{
    public void Calculate()
    {
        int length=15;
        int breadth=14;
        int height=12;

        int volume=length*breadth*height;
        Console.WriteLine($"Total volume is {volume}");
    }
}