// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Исходный массив
        int[] array = { 1, 3, 5, 6, 7, 8 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для вывода массива
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }
}