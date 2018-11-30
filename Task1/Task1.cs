using System;

class Task1
{
    static void Main()
    {
        int value = 2035;
        string bynary1 = Convert.ToString(value, 2);
        string bynary2 = Convert.ToString(value, 8);
        string bynary3 = Convert.ToString(value, 16);
        Console.WriteLine(bynary1);
        Console.WriteLine(bynary2);
        Console.WriteLine(bynary3);
    }
}

