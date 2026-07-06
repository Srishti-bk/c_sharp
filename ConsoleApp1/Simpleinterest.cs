//Declare variables for principal, rate, and time, then calculate simple interest.
using System;
class Simpleinterest
{
    public void Calculation(){
        double principal=1200;
        double time=3;
        double rate=2;

        double simpleInterest=(principal*time*rate)/100;
        Console.WriteLine($"The value simple interest having {principal},{time} and {rate} is {simpleInterest} ");
    
    }
}