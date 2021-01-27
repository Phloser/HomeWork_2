using System;

namespace HomeWork_2
{
    class Program
    {

         static void Main()
        {
            Console.WriteLine("Введите 3 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min ;

            if (a < b)
                 {
                    if (b < c)
                        { min = b; } 
                   else { min = c; }
                 }
            else { 
                    if (a < c) 
                         { min = a; } 
                    else { min = c; } 
                 }
            Console.WriteLine($"Самое маленькое число {min}");

        }

        
    }
}
