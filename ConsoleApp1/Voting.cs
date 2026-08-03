// 5. Voting Eligibility
//Input age and determine whether a person is eligible to vote (18 or above).
using System;
class Voting
{
    public void Determine()
    {
        int age;
        Console.WriteLine("Enter a age:");
        age=Convert.ToInt32(Console.ReadLine());

        if (age==18)
        {
            Console.WriteLine("A person is eligible to vote");
        }
        else if (age>18)
        {
            Console.WriteLine("A person is eligible to vote");
        }
        else
        {
            Console.WriteLine("A person is not eligible to vote");
        }
    }
}