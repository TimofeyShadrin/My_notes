void FillArray(int[] collection) // метод для заполнения массива
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        //collection[index] = new Random().Next(1, 10);
        collection[index] = Convert.ToInt32(Console.ReadLine().ToString());
        index++;
    }

}

void PrintArray(int[] col) // выводим массив в консоль в виде [1, 2, 3, 4, 5, 6, 7, 8, 9]
{
    int count = col.Length;
    int position = 1;
    
    Console.Write($"[{col[0]},");

    while (position < count - 1)
    {
        Console.Write($" {col[position]},");
        position++;
    }

    Console.WriteLine($" {col[count] - 1}]");
}