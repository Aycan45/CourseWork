using System;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Задача 36e:");
        Console.Write("Enter x:");
        sbyte x = sbyte.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        sbyte y = sbyte.Parse(Console.ReadLine());
        Console.Write("Enter z:");
        sbyte z = sbyte.Parse(Console.ReadLine());
        if (x > 0 || y > 0 || z > 0)
        {
            Console.WriteLine("It is true!");
        }
        else
        {
            Console.WriteLine("It is false!");
        }
    }
}

