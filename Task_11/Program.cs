using System;


class Program
{
    static void Main()
    {
        /* Дадено е число n и позиция p. Напишете поредица от операции, които да отпечатат стойността на бита 
        на позиция p от числото n(0 или 1). Пример: n = 35, p = 5-> 1.Още един пример: n = 35, p = 6-> 0. */

        Console.Write("Въведeте n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Въведете p: ");
        int p = int.Parse(Console.ReadLine());

        int x = 1;
        int mNew = x << p;
        int result = n & mNew;

        Console.Write("Бита на позиция p от числото n: ");
        if ( result == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(1);
        }

    }
}

