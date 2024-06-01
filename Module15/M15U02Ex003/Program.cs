namespace M15U02Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Random random = new Random();
                var numbers = new[] { random.Next(1, 9), random.Next(1, 9), random.Next(1, 9) };

                foreach ( var number in numbers )
                {
                    Console.Write(number+" ");
                }
                Console.WriteLine("\nСумма: "+numbers.Sum());

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
