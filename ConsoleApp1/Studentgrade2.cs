using System;
class Studentgrade2
{
    public void Display()
    {
        for(int studentNo = 1; studentNo < 5; studentNo++)
        {
            Console.WriteLine("Student" + studentNo);

            string name;
            Console.WriteLine("Enter a name:");
            name=Console.ReadLine();

            for(int subjectNo=1;subjectNo<4;subjectNo++){
            Console.WriteLine("Subject" + subjectNo);
            double VP;
            double CN;
            double SEP;
           double totalMarks;
           double percentage;

            Console.WriteLine("Enter a marks of VP:");
            VP=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a marks of CN:");
            CN=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a marks of SEP:");
            SEP=Convert.ToDouble(Console.ReadLine());

            totalMarks=CN+VP+SEP;
            percentage = (totalMarks/300)*100;
              }
        }
    }
}