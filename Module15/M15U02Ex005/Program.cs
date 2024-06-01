namespace M15U02Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var numbers = new List<int>
                {
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                    random.Next(1,100),
                };

                foreach (var number in numbers)
                {
                    Console.Write(number+" ");
                }

                Console.WriteLine($"\nМаксимальное число: {numbers.Max()}\n" +
                    $"Минимальное число: {numbers.Min()}\n" +
                    $"Среднее число: {numbers.Average()}");

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
