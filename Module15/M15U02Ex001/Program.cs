namespace M15U02Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int result = numbers.Aggregate((x,y)=>x-y);

            Console.WriteLine(result);
        }
    }
}
