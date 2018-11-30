using System;
using System.Linq;


class Task6
{
    static void Main()
    {
        Console.WriteLine("Задача 408:");
        int[] a = new int[5];
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("a[" + i + "]=");
            a[i] = int.Parse(Console.ReadLine());
        }
        Average(a);
        Console.Write("Въведете n:");
        int n = int.Parse(Console.ReadLine());
        double[] A = new double[n];
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("A[" + i + "]=");
            A[i] = double.Parse(Console.ReadLine());
        }
        double averageA = A.Average();
        Console.WriteLine("Средното аритметично на масива А е:" + averageA);

        double[] B = new double[n];
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write("B[" + i + "]=");
            B[i] = double.Parse(Console.ReadLine());
        }
        double averageB = B.Average();
        Console.WriteLine("Средното аритметично на масива B е:" + averageB);

        double[] C = new double[n];
        for (int i = 0; i < C.Length; i++)
        {
            Console.Write("C[" + i + "]=");
            C[i] = double.Parse(Console.ReadLine());
        }
        double averageC = C.Average();
        Console.WriteLine("Средното аритметично на масива С е:" + averageC);
        for (int i = 0; i < C.Length; i++)
        {
            Array.Sort(C);
            double b = C[1] - C[0];
            double Ap = C[i] + (Math.Pow(n,2)+1)*b;

            Console.WriteLine("Елементите на масива С са равни на " + Ap);
        }
        if (averageA > averageB && averageA > averageC)
        {
            Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е " + averageA);
        }
        else if (averageB > averageA && averageB > averageC)
        {
            Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е " + averageB);
        }
        else if (averageC > averageA && averageC > averageB)
        {
            Console.WriteLine("Максималната стойност от средноаритметичните на трите масива е " + averageC);
        }
    }
    static void Average(int[] a)
    {   
        double sum = 0;
        double number = 0;
        double avrg = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > -100 && a[i] < 100)
            {
                sum = sum + a[i];
                number = number + 1;
            }
        }
        avrg = sum / number;
        Console.WriteLine("Средното аритметично на масива е:" + avrg);
    }
}

