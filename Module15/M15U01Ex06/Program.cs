namespace M15U01Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine().ToCharArray();

            char[]chars = {' ','.',',','!','?',':',';'};

            if (text.Length>0)
            {
                var uniqueSymbols = text.Distinct().Except(chars);

                Console.Write($"Уникальные символы ({uniqueSymbols.Count()} шт): ");
                foreach (var ch in uniqueSymbols)
                {
                    Console.Write(ch + " ");
                }
            }
            else
            {
                Console.WriteLine("Пустая строка");
            }
        }
    }
}
