// Created by: Venika Sem
// Created on: May 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int integer1;
        int integer2;
        var addedInteger = 0;
        var answer = 0;

        Console.Write("Input first integer: ");
        integer1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input second integer: ");
        integer2 = Convert.ToInt32(Console.ReadLine());

        if (integer1 > 0 && integer2 > 0)
        {
            while (addedInteger < integer2)
            {
                addedInteger = addedInteger + 1;
                answer = answer + integer1;
            }
        }
        else if (integer1 < 0 && integer2 < 0)
        {
            while (addedInteger > integer2)
            {
                addedInteger = addedInteger - 1;
                answer = answer - integer1;
            }
        }
        else if (integer1 > 0 && integer2 < 0)
        {
            while (addedInteger > integer2)
            {
                addedInteger = addedInteger - 1;
                answer = answer - integer1;
            }
        }
        else if (integer1 < 0 && integer2 > 0)
        {
            while (addedInteger < integer2)
            {
                addedInteger = addedInteger + 1;
                answer = answer + integer1;
            }
        }
        Console.WriteLine("The answer is: " + integer1 + " x " + addedInteger + " = " + answer);
    }
}