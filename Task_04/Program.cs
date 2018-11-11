using System;


    class Program
    {
        static void Main()
        {
        // Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.

            Console.Write("Въведете число: ");

            int number = int.Parse(Console.ReadLine());
            bool bitnum = (number & 8) != 0;

            Console.WriteLine(bitnum);
    }
    }

