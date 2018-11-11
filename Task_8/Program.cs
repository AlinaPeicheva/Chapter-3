using System;


class Program
{
    static void Main()
    {
        /* Напишете програма, която проверява дали дадена точка О {x, y} е вътре в окръжността К({ 0,0}, R = 5). 
           Пояснение: точката { 0,0}  е център на окръжността, а радиусът и е 5. */

        Console.Write("Въведете x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Въведете y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        if (x * x + y * y <= 25)
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

