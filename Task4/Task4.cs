using System;

class Task4
{
    static void Main()
    {
        Console.WriteLine("Задача 78:");
        double a = 0, k;
        for (k = 1; k <= 100; k++)
            a += Math.Pow(k,2) / (Math.Pow(k,3)+ 1);
        Console.WriteLine(a);
    }
}

