using System;
class Arraydecimal
{
    public void Display()
    {
        Console.WriteLine($"Enter the size of the Array:");
        int size=int.Parse(Console.ReadLine());

        double[] arr = new double[size];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("Decimal"   +  (i + 1)    + ":");
            arr[i]=Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter the element of array:");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine(arr[i] + "");
        }

    }
}