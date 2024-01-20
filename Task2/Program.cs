//Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.


using System;

class Program
{
    static void Main()
    {
        // задаём размер массива
        int arraySize = 10;
        
        int[] randomNumbers = GenerateRandomNumbers(arraySize);

        PrintArray(randomNumbers);

        int evenCount = CountEvenNumbers(randomNumbers);

        Console.WriteLine($"Количество четных чисел: {evenCount}");
    }

    // генерации случайных трехзначных чисел
    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        return numbers;
    }

    // вывода массива
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // подсчет четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}
