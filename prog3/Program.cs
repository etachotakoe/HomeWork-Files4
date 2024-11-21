using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать\r\nизображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль\r\nдолжна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если\r\nпользователь ввёл не цифру, то программа должна выпасть в исключение. Программа\r\nзавершает работу, если пользователь введёт слово: exit или закрыть (оба варианта\r\nдолжны сработать) - консоль закроется.");
            Console.Write("Введите число (или 'exit'/'закрыть' для выхода): ");
            string input = Console.ReadLine();

            
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            try
            {
                
                int number = int.Parse(input);

                if (number >= 0 && number <= 9)
                {
                    DrawDigit(number);
                }
                else
                {
                   
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Ошибка: число должно быть от 0 до 9!");
                    System.Threading.Thread.Sleep(3000); // задержка на 3 секунды
                    Console.ResetColor(); // cбрасываем цвет консоли
                }
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Ошибка: введено не число.");
            }
            catch (OverflowException)
            {
                
                Console.WriteLine("Ошибка: число вне допустимого диапазона.");
            }
        }
    }

    static void DrawDigit(int digit)
    {
        switch (digit)
        {
            case 0:
                Console.WriteLine(" ### \n#   #\n#   #\n#   #\n ### ");
                break;
            case 1:
                Console.WriteLine("  #  \n ##  \n  #  \n  #  \n ### ");
                break;
            case 2:
                Console.WriteLine(" ### \n    #\n ### \n#    \n ### ");
                break;
            case 3:
                Console.WriteLine(" ### \n    #\n ### \n    #\n ### ");
                break;
            case 4:
                Console.WriteLine("#   #\n#   #\n ### \n    #\n    #");
                break;
            case 5:
                Console.WriteLine(" ### \n#    \n ### \n    #\n ### ");
                break;
            case 6:
                Console.WriteLine(" ### \n#    \n ### \n#   #\n ### ");
                break;
            case 7:
                Console.WriteLine(" ##### \n    #\n   # \n  #  \n #   ");
                break;
            case 8:
                Console.WriteLine(" ### \n#   #\n ### \n#   #\n ### ");
                break;
            case 9:
                Console.WriteLine(" ### \n#   #\n ### \n    #\n ### ");
                break;
        }
    }
}
