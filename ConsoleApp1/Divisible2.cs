//Determine whether a number is divisible by both 5 and 11.
class Divisible2
{
    public void Check()
    {
        int num;
        Console.WriteLine("Enter a number:");
        num = Convert.ToInt32(Console.ReadLine());

        if(num%5==0 && num%11 == 0)
        {
            Console.WriteLine($"{num} is divisible by 5 and 11");
        }
        else
        {
            Console.WriteLine($"{num} is not divisible by 5 and 11");
        }
    }
}