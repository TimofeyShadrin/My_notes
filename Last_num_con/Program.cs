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

    while (position < count - 1)
    {
        Console.Write($" {col[position]},");
        position++;
    }

    Console.WriteLine($" {col[count - 1]}]");
    }

int attempts = 0;
string? input = Console.ReadLine();
char[] collection = values(input);
PrintArrayChar(collection);
Console.WriteLine(collection.Length);
int[] numbers = data(input);
PrintArrayInt(numbers);



// while (attempts < 3)
// {
//     values(input);
//     attempts++;
// }