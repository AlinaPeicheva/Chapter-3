using System;


class Program
{
    static void Main()
    {
        // Напишете булев израз, който да проверява дали дадено цяло число сe дели и на 5, и на 7 без остатък.

        Console.Write("Въведете число: ");

        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            bool bool1 = true;
            Console.WriteLine(bool1);
        }
        else
        {
            bool bool1 = false;
            Console.WriteLine(bool1);
        }
    }
}
