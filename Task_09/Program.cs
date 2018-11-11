using System;


class Program
{
    static void Main()
    {   /* Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К({ 0,0}, R = 5) 
        и едновременно с това извън правоъгълника[{ -1, 1}, { 5, 5}]. 
        Пояснение: правоъгълникът е зададен чрез координатите на долния си ляв и горния си десен ъгъл. */

        Console.Write("Въведете X координати: ");
        decimal x = decimal.Parse(Console.ReadLine());

        Console.Write("Въведете Y координати: ");
        decimal y = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        if (x <= 6 && y <= 6 && (x * x) + (y * y) <= 25)
        {
            Console.WriteLine("Вътря в окръжността");
        }
        else
        {
            Console.WriteLine("Извън окръжността");
        }
        Console.ReadLine();

    }
}
