using System;


class Program
{
    static void Main()
    {
        // Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

        Console.Write("Въведете число: ");

        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Числото е четно");
        }
        else
        {
            Console.WriteLine("Числото е нечетно");
        }
    }
}

