//Create variables for five subject marks and calculate the average.
using System;
class Average
{
    public void Calculation()
    {
        int mathematics = 50;
        int physics = 35;
        int chemistry = 27;
        int nepali = 55;
        int english = 40;

        double average= (mathematics+physics+chemistry+nepali+english)/5;
        Console.WriteLine($"The average of a five subjects having marks {mathematics},{physics},{chemistry},{nepali} and {english} is {average}");
    }
}