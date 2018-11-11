using System;


class Program
{
    static void Main()
    {
        // Напишете израз, който да проверява дали третата цифра (от дясно наляво) на дадено цяло число е 7.

        Console.Write("Въведете число: ");

        int number = int.Parse(Console.ReadLine());
        int a = number / 100;
        int b = a % 10;

        if (b == 7)
        {
            Console.WriteLine("Третата цифра на дадяно число е 7");
        }
        else
        {
            Console.WriteLine("Третата цифра на дадяно число не е 7");
        }
    }
}

