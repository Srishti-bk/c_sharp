//WAP in c# to store number in 1D array from user and display their elements
using System;
class Array
{
    public void Singledimen()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] arr=new int[size];
        for(int i = 0; i < arr.GetLength(0);i++){
            Console.WriteLine("Number " + (i + 1) + ":");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the element:");
        for(int i=0;i<arr.GetLength(0);i++)
        {
            Console.WriteLine(arr[i] + "");
        }
    }
}