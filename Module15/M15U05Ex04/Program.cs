namespace M15U05Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var evenNumbers = numbers.Where(x=>x%2==0).ToList();
            numbers.Add(12);

            foreach(int x in evenNumbers)
            {
                Console.Write(x+" ");
            }
        }
    }
}
