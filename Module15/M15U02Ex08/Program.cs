﻿namespace M15U02Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                try
                {
                    Console.Write("Введите длину списка: ");
                    if (int.TryParse(Console.ReadLine(),out int listCount))
                    {
                        var numbers = new List<int>();
                        for (int i = 0;i< listCount; i++)
                        {
                            Console.Write($"Число №{i+1}: ");
                            if (int.TryParse(Console.ReadLine(), out int number))
                            {
                                numbers.Add(number);
                            }
                            else
                            {
                                throw new ArgumentException("Введите верное число");
                            }
                        }
                        Console.WriteLine($"\nДлина списка: {numbers.Count()}\n" + $"" + $"" + $"Сумма всех чисел: {numbers.Sum()}\n" + $"" + $"" + $"Максимальное число: {numbers.Max()}\n" + $"Минимальное число: {numbers.Min()}\n" + $"Среднее число: {numbers.Average()}");
                    }
                    else
                    {
                        throw new ArgumentException("Введите верное число");
                    }

                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }



                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
