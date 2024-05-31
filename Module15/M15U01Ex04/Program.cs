namespace M15U01Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово №1: ");
            string word1=Console.ReadLine();
            Console.Write("Введите слово №2: ");
            string word2 = Console.ReadLine();

            var wordChar1 = word1.ToCharArray();
            var wordChar2 = word2.ToCharArray();

            var sameChars=wordChar1.Intersect(wordChar2);            
            Console.Write($"Одинаковые быквы ({sameChars.Count()} шт): ");

            foreach( var word in sameChars )
            {
                Console.Write(word+" ");
            }
        }
    }
}
