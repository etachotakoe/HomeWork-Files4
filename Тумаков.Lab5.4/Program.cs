using System;

class Program
{
   
    static long Factorial(int n)
    {
        
        if (n == 0 || n == 1)
        {
            return 1;
        }
        
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.");
        int number = Convert.ToInt32(Console.ReadLine()); ; 
        long result = Factorial(number);
        Console.WriteLine($"Факториал числа {number} равен {result}");
    }
}
