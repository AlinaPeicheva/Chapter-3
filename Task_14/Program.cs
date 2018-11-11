using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто
        // (т.е.се дели без остатък само на себе си и на единица).

        int number = 64;
        bool pNum = true;

        if (number > 2)
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) pNum = false;
            }
        Console.WriteLine("{0} е просто: {1}", number, pNum);


    }
}

