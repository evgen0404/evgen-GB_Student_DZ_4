// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine();

           
            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsEvenDigitSum(number))
                {
                  break;
                }
            }
        }
        Console.WriteLine("Программа завершена.");
    }

    static bool IsEvenDigitSum(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum % 2 == 0;
    }
}

