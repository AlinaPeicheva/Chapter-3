using System;


class Program
{
    static void Main()
    {
        // Напишете израз, който изчислява площта на трапец по дадени страни a и b и височина h.
        Console.Write("Въведете a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Въведете b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Въведете h: ");
        int h = int.Parse(Console.ReadLine());

        int S;
        S = (a + (b - a) / 2) * h;
        System.Console.Write("S = ");
        Console.WriteLine((a + (b - a) / 2) * h);
    }
}

