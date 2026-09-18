using System;
class Jaggedarray()
{
    public void Display()
    {
        int[][] number=new int[3][];
        number[0]=new int[] {1,2,3};
        number[1]=new int[] {1,2,3,4};
        number[2]=new int[] {1,2,3,4,5};

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("numbers" +(i+1)+":");
            foreach(int num in number[i]){
                Console.Write(num +"");
                Console.WriteLine();
            }
        }
    }
}