//WAP in c# to store string in 2D array from user and display their elements
using System;
using System.Data;
class Array2string
{
    public void Display()
    {
        Console.WriteLine("Enter the size of the row:");
        int row=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the size of the column:");
        int column=int.Parse(Console.ReadLine());

        string[,] arr=new string[row,column];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("row" +(i+1)+ ":");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine("column" +(j+1)+ ":");
                arr[i,j]=Console.ReadLine();
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
