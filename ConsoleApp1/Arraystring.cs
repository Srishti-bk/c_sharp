using System;
class Arraystring
{
    public void Display()
    {
        Console.WriteLine($"Enter the size of the Array:");
        int size=int.Parse(Console.ReadLine());

        string[] arr = new string[size];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("String " + (i + 1) + ":");
            arr[i]=Console.ReadLine();
        }
        Console.WriteLine("Enter the element of array:");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine(arr[i] + "");
        }

    }
}