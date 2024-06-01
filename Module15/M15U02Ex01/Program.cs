using System.Data;

namespace M15U02Ex01
{
    internal class Program
    {
        static long Factorial(long number)
        {
            var numberList= new List<long>();
            for (int i = 1; i <= number; i++)
            {
                numberList.Add(i);
            }

            return numberList.Aggregate((x,y)=>x*y);
        }
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Write("Введите число: ");
                try
                {
                    if (long.TryParse(Console.ReadLine(), out long number))
                    {
                        Console.WriteLine($"Факториал {number} = {Factorial(number)}");
                    }
                    else
                    {
                        throw new ArgumentException("Неверный формат");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }






                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
