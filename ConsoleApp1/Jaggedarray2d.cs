//Write a program in c# to store number in jagged Array should be of 2D.
using System;
using System.Globalization;
class Jaggedarray2d
{
    public void Array()
    {
        int[][,] number=new int[3][,];
        number[0]=new int[,]{{1 , 2},
                            {4 , 5}};
        number[1]=new int[,]{{1 , 2, 3},
                         {5 , 6 , 7}};
        number[2]=new int[,]{{8 , 5 , 4},
                          {3 , 7 , 9}};
        

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("numbers" +(i+1)+":");
            for(int j=0;j<number[i].GetLength(0);j++){
                for(int k=0;k<number[i].GetLength(1);k++){
                    Console.Write(number[i][j,k] +"");
                    
            }
            Console.WriteLine();
           
        
            }
            Console.WriteLine();
        }


    }
}