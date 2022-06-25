void FillArray(int[] collection) // метод для заполнения массива
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        //collection[index] = new Random().Next(1, 10);
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }

}

void PrintArray(int[] col) // метод для вывода массива в консоль в виде [1, 2, 3, 4, 5, 6, 7, 8, 9]
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

int[] sortedArray (int[] Array) // метод сортировки массива выбором
{
    int index = 0;
    int size = Array.Length;
    int indexMin = 0;

    while (index < size - 1)
    {
        int count = index + 1;
        int min = Array[index];

        while (count < size)
        {
            if (Array[count] < min) 
            {
                min = Array[count];
                indexMin = count;
            }
            count++;

        }

        if (min != Array[index]) 
        {
            int temp = Array[index];
            Array[index] = min;
            Array[indexMin] = temp;
        }
        index++;
    }

    return Array;
}

Console.Write("Пожалуйста введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[l];
Console.Clear();

Console.WriteLine($"Пожалуйста введите {l} элемент(-а, -ов) массива, подтверждая каждый клавишей Enter");

FillArray(Arr);
Console.Clear();

Console.WriteLine("Вы ввели следующий массив для сортировки выбором:");
PrintArray(Arr);

Arr = sortedArray(Arr);
Console.WriteLine();

Console.WriteLine("Теперь после сортировки Ваш массив выглядет так:");
PrintArray(Arr);
Console.WriteLine();