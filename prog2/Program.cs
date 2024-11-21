using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { 1, 2, 3, 4, 5 };

       
        int product = 1; 
        double average;

        
        int sum = Calculate(ref product, out average, numbers);

        Console.WriteLine("2. Написать метод, где в качества аргумента будет передан массив (ключевое слово\r\nparams). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение\r\nмассива. Вывести (out) среднее арифметическое в массиве.");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Среднее арифметическое: {average}");
    }

    
    static int Calculate(ref int product, out double average, params int[] numbers)// метод принимающий массив возвращающий сумму произведение по ссылке и среднее арифметическое по out
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        average = (double)sum / numbers.Length;

        return sum; 
    }
}
