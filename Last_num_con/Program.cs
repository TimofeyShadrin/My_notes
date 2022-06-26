char[] values (string text)
{
    char[] values = {'a'};
    int index = 0;
    foreach (char c in text)
    {
        values[index] = c;
        index++;
        Array.Resize (ref values, index + 1);
    }
    Array.Resize (ref values, index);
    return values;
}

int[] data (string text)
{
    int[] data = {0};
    int index = 0;
    
    foreach (char c in text)
    {
        if (c == '0' || c == '1')
        {
            data[index] = c - '0';
            index++;
            Array.Resize (ref data, index + 1);
        }
        else if (c == '2' || c == '3')
        {
            data[index] = c - '0';
            index++;
            Array.Resize (ref data, index + 1);
        }
        else if (c == '4' || c == '5')
        {
            data[index] = c - '0';
            index++;
            Array.Resize (ref data, index + 1);
        }
        else if (c == '6' || c == '7')
        {
            data[index] = c - '0';
            index++;
            Array.Resize (ref data, index + 1);
        }
        else if (c == '8' || c == '9')
        {
            data[index] = c - '0';
            index++;
            Array.Resize (ref data, index + 1);
        }
        else
        {
            continue;
        }
        Array.Resize (ref data, index + 1);
    }
    return data;
}

void PrintArrayChar(char[] col) // метод для вывода массива в консоль в виде [a, b, c, d, e, f, g, h, i]
{
    int count = col.Length;
    int position = 1;
    
    Console.Write($"[{col[0]},");

    while (position < count - 1)
    {
        Console.Write($" {col[position]},");
        position++;
    }

    Console.WriteLine($" {col[count - 1]}]");
    }

void PrintArrayInt(int[] col) // метод для вывода массива в консоль в виде [1, 2, 3, 4, 5, 6, 7, 8, 9]
{
    int count = col.Length;
    int position = 1;
    
    Console.Write($"[{col[0]},");

    while (position < count - 2)
    {
        Console.Write($" {col[position]},");
        position++;
    }

    Console.WriteLine($" {col[count - 2]}]");
    }

Console.Clear();
Console.Write($"Ведите пожалуйста целое трехзначное число: ");
string? input = Console.ReadLine();

if (input != "")
{
char[] collection = values(input);
Console.WriteLine();
Console.WriteLine("Вы ввели следующие символы, проверьте!");
PrintArrayChar(collection);
Console.WriteLine();
Console.WriteLine("Ничего страшного, если Вы ошиблись!");
Console.WriteLine("Мы сами выберем цифры из введеного Вами!");
int[] numbers = data(input);
PrintArrayInt(numbers);
Console.WriteLine();
Console.WriteLine("И не смотря на то, что количество может отличаться от заданного,");
Console.WriteLine("мы все равно определим последнюю цифру. Вот она!");
Console.WriteLine();
Console.WriteLine($" Это: {numbers[numbers.Length - 2]}");
Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Вы ничего не ввели!");
    Console.WriteLine();
}
