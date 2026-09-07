//WAP in c# to store number in 2D array from user and display their elements
using System;
using System.Data;
class Array2
{
    public void Twodimen()
    {
        int[,] matrix=new int[4,5];

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine(i+1);
            for(int j = 0; j < 5; j++)
            {
                
                matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                Console.Write(matrix[i, j] + " "); 

            }
            

            
        }
    }
    
}