using System;

class Program
{
  
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 5;
        int y = 10;

        Console.WriteLine("Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых\r\nпараметров. Параметры передавать по ссылке. Протестировать метод.");
        Console.WriteLine($"До обмена: x = {x}, y = {y}");

        Swap(ref x, ref y);

        Console.WriteLine($"После обмена: x = {x}, y = {y}");
    }
}
