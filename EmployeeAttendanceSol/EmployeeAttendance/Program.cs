using System;
namespace Employee;

class Emp
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        int WAGE_PER_HOUR = 20;
        int Emphrs = 0;
        int Empwage = 0;

        Random random = new Random();
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            Emphrs = 8;

        }
        else
        {
            Emphrs = 0;

        }
        Empwage = Emphrs * WAGE_PER_HOUR;
        Console.Write("Employee Wage is " + Empwage);
    }
}