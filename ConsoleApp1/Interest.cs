//14.Calculate compound interest using variables.
using System;
class Interest
{
    public void Calculation()
    {
        int principal=50000;
        int time=3;
        int rate=2;

        double amount=principal*(1+rate/100)^time;

        double compoundInterest=amount-principal;

        Console.WriteLine($"The value  of a  compound interest having {principal} principal , {time} time , {rate} rate and {amount} amount is {compoundInterest} ");
    }
}