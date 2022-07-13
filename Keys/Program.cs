namespace Keys
{
    class Keys
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.)
                {
                    count++;
                }
            }
            Console.WriteLine("count: " + count);
        }
    }
}
