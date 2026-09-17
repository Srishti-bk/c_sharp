//WAP in c# to store decimal in 2D array from user and display their elements
using System;
using System.Data;
class Array2decimal
{
    public void Display()
    {
        Console.WriteLine("Enter the size of the row:");
        int row=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the size of the column:");
        int column=int.Parse(Console.ReadLine());

        double[,] arr=new double[row,column];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("row" +(i+1)+ ":");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine("column" +(j+1)+ ":");
                arr[i,j]=Convert.ToDouble(Console.ReadLine());
            }
        }
            Console.WriteLine("Enter the elements of Array:");
            for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "");
                }
                Console.WriteLine();
                }
                
        }
}
