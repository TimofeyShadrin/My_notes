// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа.
// Пример:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Пожалуста введите целое число: ");

string input = Console.ReadLine();
int[] array = {0};
int index = 0;

foreach (char c in input)
    {
        array[index] = c - '0';
        index++;
        Array.Resize(ref array, index + 1);
    }

Console.WriteLine();
Console.Write("Последняя цифра вашего числа это: ");
Console.WriteLine(array[input.Length - 1]);
Console.WriteLine();