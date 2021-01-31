using System;

namespace HomeWork_2
{
    enum status { login, notlogin, error }

    class Program
    {
        static void dz()
        {
            Console.WriteLine("Добро пожаловать, проверяющий!");
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
        static void error()
        {
            //status user = status.error;
            Console.WriteLine("Ошибка входа!!!");
        }

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
            int x = 0; int y = 0;
                Console.WriteLine("Вводите числа (окончание ввода 0)");
            
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x > 0) { if (x % 2 != 0) { y = y + x; }
                        }
            }
            while ( x != 0);

            Console.WriteLine($"Сумма нечетных {y} ");
        } // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел

        static void Main(string[] args)
        {
            status user = status.notlogin;
            int cont = 4;
            string logtrue = "root";
            string pastrue = "geekbrain";
            do
            {
                cont--;
                Console.WriteLine($"Введите login, осталось {cont} попыток");
                string login;
                string pass;
                login = Console.ReadLine();
                if (login == logtrue)
                {
                    Console.WriteLine("Введите пароль");
                    pass = Console.ReadLine();
                    if (pass == pastrue)
                    {
                        user = status.login;
                        Console.WriteLine(user);
                    }
                    else Console.WriteLine(user);
                }
                else Console.WriteLine(user);
            } while (cont < 4 & cont > 0 & user == status.notlogin);
            switch (user)
            {
                case status.login: dz(); break;
                case status.notlogin: error(); return;
            }


        }


    }
}
