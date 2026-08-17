using System;

class studentsGrade
{
    public void Display()
    {
        for (int studentNo = 1; studentNo <5; studentNo++)
        {
            Console.WriteLine("Student " + studentNo);

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter exam score: ");
            double examScore = Convert.ToDouble(Console.ReadLine());

            char grade;

            if (examScore < 60)
            {
                grade = 'F';
            }
            else if (examScore <= 70)
            {
                grade = 'D';
            }
            else if (examScore <= 80)
            {
                grade = 'C';
            }
            else if (examScore <= 90)
            {
                grade = 'B';
            }
            else
            {
                grade = 'A';
            }

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Exam Score: " + examScore);
            Console.WriteLine("Final Grade: " + grade);
            Console.WriteLine();
        }
    }
}