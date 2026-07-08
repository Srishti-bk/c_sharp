//Store the temperature in Celsius and convert it to Fahrenheit.
using System;
class Temperature
{
    public void Convert()
    {
        int celsius=20;
        double fahrenheit = (celsius*9/5)+32;

        Console.WriteLine($"The temperature in {celsius} after converting it in fahrenheit is {fahrenheit}"); 
    }
}