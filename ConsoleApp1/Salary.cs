//12.Declare variables for employee name, basic salary, bonus, and tax, then calculate the net salary.
using System;
class Salary
{
    public void Details(){
        string name = "srishti";
        int salary = 20000;
        int bonus = 5000;
        int tax = 5500;
        int netSalary = salary + bonus-tax;
         Console.WriteLine($"The Net Salary of the employee having  name {name} salary {salary},bonus {bonus} and tax {tax} is {netSalary}");
    }
}