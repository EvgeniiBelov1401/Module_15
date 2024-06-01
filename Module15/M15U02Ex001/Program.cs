namespace M15U02Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int minus = numbers.Aggregate((x,y)=>x-y);
            int sum=numbers.Aggregate((x,y)=>y+x);

            Console.WriteLine(minus);
            Console.WriteLine(sum);
        }
    }
}
