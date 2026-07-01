//Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.

using System;
public class Totalmarks
{
    public void Marks()
    {
    int Physics = 50;
    int Chemistry = 35;
    int Mathematics = 55;
    int Calculation = Physics + Chemistry + Mathematics;

    Console.WriteLine($"Total marks of {Physics} , {Chemistry} and {Mathematics} is {Calculation} ");


    }
}