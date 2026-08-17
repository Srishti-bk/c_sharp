//Write a C# program to input the salary of 8 employees. 
//Calculate the bonus according to the following rules: 
//Salary   Bonus 
//Less than Rs. 20,000  20% 
//Rs. 20,000–39,999  15% 
//Rs. 40,000–59,999  10% 
//Rs. 60,000 and above 5% 
 //Display the salary, bonus amount, and total salary after adding the bonus.

 using System;
 class Employeesalary
{
    public void Display(){
        double salary , bonusAmount , totalSalary;


        for(int employeesNo = 1; employeesNo < 9; employeesNo ++)
        {
            Console.WriteLine("employees" + employeesNo);
    
        salary=Convert.ToDouble(Console.ReadLine());
        if (salary < 20000)
        {
              bonusAmount = salary*20/100;

        }
        else if (salary < 40000)
        {
            bonusAmount = salary*15/100;
        }
        else if (salary < 60000)
        {
            bonusAmount = salary*10/100;
        }
        else
        {
            bonusAmount = salary*5/100;
        }

         totalSalary = salary + bonusAmount;

         Console.WriteLine("salary:" + salary);
         Console.WriteLine("bonusAmount:"  + bonusAmount);
         Console.WriteLine("totalSalary:"   + totalSalary);    
    }
}
}
    