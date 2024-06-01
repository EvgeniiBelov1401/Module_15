namespace M15U02Ex03
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
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                    random.Next(1,10),
                };

                foreach (var number in numbers)
                {
                    Console.Write(number+" ");
                }
                var average =(double) numbers.Sum() / numbers.Count();
                
                Console.WriteLine($"\nСреднее арифметическое: {average}");
                Console.WriteLine($"\nСреднее арифметическое: {numbers.Average()}");
                
                
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
