namespace del120_140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 120; i < 141; i++)
            {
                Console.Write($"\n{i} => ");
                for (int j = 1; j < i + 1; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write($"{j} ");
                    }
                }
            }
            Console.Read();
        }
    }
}