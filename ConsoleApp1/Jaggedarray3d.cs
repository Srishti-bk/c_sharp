using System;
class Jaggedarray3d
{
    public void Array()
    {
        int[][,,] number=new int[2][,,];
        number[0] = new int[,,]{{{1,2},{3,4}}};
        number[1]=new int[,,]{{{5,6,7},{8,9,10}}};
       
       for(int i = 0; i < 2; i++)
        {
            Console.WriteLine("number"+(i+1)+":");
            for(int j = 0; j < number[i].GetLength(0); j++)
            {
                for(int k = 0; k < number[i].GetLength(1); k++)
                {
                    for(int l = 0; l < number[i].GetLength(2); l++)
                    {
                        Console.Write(number[i][j , k , l] +" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        
       
    }
}