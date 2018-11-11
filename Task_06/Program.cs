using System;


class Program
{
    static void Main()
    {
        /* Напишете програма, която за подадени от потребителя дължина и
        височина на правоъгълник пресмята и отпечатва на конзолата неговите периметър и лице. */

        Console.Write("Въведете a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Въведете b: ");
        int b = int.Parse(Console.ReadLine());

        int P = 2 * a + 2 * b;
        Console.WriteLine("Периметъра на правоъгълника е: " + P);

        int S = a * b;
        Console.WriteLine("Лицето на правоъгълника е: " + S);
    }
}

