using System;


    class Program
    {
        static void Main()
        {
        /* Силата на гравитационното поле на Луната е приблизително 17% от това на Земята.Напишете програма, която да изчислява 
        тежестта на човек на Луната по дадената тежест на Земята.*/
       
        Console.Write("Напишете килограмите си: ");
        int kg = int.Parse(Console.ReadLine());
        
        double newKg = kg - (kg * 0.17);
        Console.WriteLine("Вашите килограми на луната са: {0} ", newKg);
        Console.ReadLine();
         }
    }

