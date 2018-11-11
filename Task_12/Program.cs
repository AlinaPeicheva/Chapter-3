using System;


class Program
{
    static void Main()
    {
        // Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1.
        // Пример v = 5, p = 1 -> false.

        Console.Write("Въведи v: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Въведи p: ");
        int p = int.Parse(Console.ReadLine());

        int x = 1;
        int mNew = x << p;
        int result = v & mNew;

        Console.Write("Бита на позиция p от числото v:");
        if (result == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }


    }
}

