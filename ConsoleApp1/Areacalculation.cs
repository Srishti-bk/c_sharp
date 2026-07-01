using System;
 public class Areacalculation
{
    public void Calculation()
    {
        int Radius = 12;
        float pie = 3.14F;
       float Area = pie * Radius*Radius;

        Console.WriteLine($"Total area of a circle having {Radius} and {pie} is {Area}");
    }
}