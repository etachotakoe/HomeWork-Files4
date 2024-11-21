using System;

namespace SwapEl
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[20];

            
            for (int i = 0; i < numbers.Length; i++)// заполнение массива случайными числами
            {
                numbers[i] = random.Next(1, 101); 
            }

            Console.WriteLine("1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,\r\nкоторые нужно поменять местами. Вывести на экран получившийся массив.");
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

          
            Console.WriteLine("Введите первое число для замены:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число для замены:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

           
            int firstIndex = Array.IndexOf(numbers, firstNumber);
            int secondIndex = Array.IndexOf(numbers, secondNumber);

           
            if (firstIndex != -1 && secondIndex != -1)
            {
                
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

               
                Console.WriteLine("Измененный массив:");
                PrintArray(numbers);
            }
            else
            {
                Console.WriteLine("Одно или оба числа не найдены в массиве.");
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
