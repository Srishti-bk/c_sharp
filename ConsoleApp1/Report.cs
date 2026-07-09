//Store a student's information (Name, Roll No, Faculty, GPA) and display it in a formatted report
using System;
public class Report
{
    public void Information()
    {
        string Name="srishti";
        int rollNo=20;
        string faculty="computer engineering";
        double gpa=2.94;

        Console.WriteLine("Name:" + Name);
        Console.WriteLine("rollNo:" + rollNo);
        Console.WriteLine("faculty:" + faculty);
        Console.WriteLine("gpa:" + gpa);
    }
}