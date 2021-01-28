using System;

namespace HomeWork_2
{
    class Program
    {
        static void Task1()
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
            Console.ReadKey();
            Console.Clear();
        } // Написать метод, возвращающий минимальное из трех чисел
        static void Task2()
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            int count = 0;
            foreach (char symbol in a)
            {
                count++;
            }
            Console.WriteLine($"в числе {count} знаков");
            Console.ReadKey();
            Console.Clear();
        } // Написать метод подсчета количества цифр числа
        static void Task3()
        {
            int y = 0; int x = 1;
            Console.WriteLine("ВВодите числа (окончание ввода 0)");
            while (x > 0; x < 0)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) { }
                else { y = y + x; }
            }
        } // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел


        static void Main()
        {
            while (true)
            {
                Console.WriteLine($"Введите номер задания (0 - выход):");
                var index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 0:
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                }
            }

        }

        
    }
}
