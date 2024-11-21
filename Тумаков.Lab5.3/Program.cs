using System;

class Program
{
    
    static bool Factorial(int number, out long result)
    {
        result = 1; //инициализация результата

        if (number < 0)
        {
            return false; // факториал отриц числа не определен
        }

        try
        {
            for (int i = 2; i <= number; i++)
            {
                result = checked(result * i); 
            }
            return true; 
        }
        catch (OverflowException)
        {
            return false; 
        }
    }

    static void Main()
    {
        
        int[] testNum = { 5, 10, 20, -1, 21 }; // включаем отриц число и число которое вызывает переполнение

        foreach (var number in testNum)
        {
            if (Factorial(number, out long factorialResult))

            {
                Console.WriteLine("Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений\r\nпередавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;\r\nесли в процессе вычисления возникло переполнение, то вернуть значение false. Для\r\nотслеживания переполнения значения использовать блок checked.");
                Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
            }
            else
            {
                Console.WriteLine($"Не удалось вычислить факториал числа {number}. Возможно, произошла ошибка переполнения.");
            }
        }
    }
}
