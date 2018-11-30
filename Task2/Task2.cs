using System;

class Task2
{
    static void Main()
    {
        Console.WriteLine("Тест 1 - 7 I):");
        Console.Write("Enter H:");
        double H = double.Parse(Console.ReadLine());
        Console.Write("Enter R:");
        double R = double.Parse(Console.ReadLine());
        Console.Write("Enter r:");
        double r = double.Parse(Console.ReadLine());
        double V = Math.PI * H * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2)) / 3;
        Console.WriteLine($"The V is {V}");
    }
}

