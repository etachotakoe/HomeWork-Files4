using System;

class Program
{

    static int Max(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        Console.WriteLine("Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные\r\nпараметры метода – два целых числа. Протестировать метод.");
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(Max(30, 15));
        Console.WriteLine(Max(-5, -10));
        Console.WriteLine(Max(0, 7));
    }
}