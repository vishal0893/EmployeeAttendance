﻿using System;
namespace Employee;

class Emp
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        if(empCheck == IS_FULL_TIME)
        {
            Console.Write("Employee is present");

        }
        else 
        {
            Console.Write("Employee is absent");

        }
    }
}