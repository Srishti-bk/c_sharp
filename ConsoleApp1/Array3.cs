using System;
using System.Runtime.Serialization.Formatters;
class Array3
{
    public void Display()
    {
        Console.WriteLine($"Enter the size of a depth:");
        int depth=int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the size of a row:");
        int row=int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the size of a column:");
        int column=int.Parse(Console.ReadLine());

        int[,,] number=new int[depth,row,column];
        for(int i = 0; i < number.GetLength(0); i++)
        {
            for(int j = 0; j < number.GetLength(1); j++)
            {
                for(int k = 0; k < number.GetLength(2); k++)
                {
                    Console.WriteLine("Depth"   +  (i + 1)    + ":");
                    Console.WriteLine("row"   +  (j + 1)    + ":");
                    Console.WriteLine("column"   +  (k + 1)    + ":");
                    number[i,j,k]=Convert.ToInt32(Console.ReadLine());
                }
            }
        }
            Console.WriteLine("Enter the element of Array:");
            for(int i = 0; i < number.GetLength(0); i++)
        {
            for(int j = 0; j < number.GetLength(1); j++)
            {
                for(int k = 0; k < number.GetLength(2); k++)
                    {
                        Console.Write(number[i,j,k] + "");
                    }
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
            
        
    }
}