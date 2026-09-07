//WAP in c# to store number in 1D array from user and display their elements
using System;
class Array
{
    public void Singledimen()
    {
        int[] arr=new int[3];
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Number" + (i+1) + ":");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
}