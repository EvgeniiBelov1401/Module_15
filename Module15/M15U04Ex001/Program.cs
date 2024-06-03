namespace M15U04Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letters = new string[] { "A", "B", "C", "D", "E" };
            var numbers = new int[] { 1, 2, 3 };
            var numbers2 = new int[] { 1, 2, 3 };

            var zip=letters.Zip(numbers,(l,n)=>l+n.ToString());

            foreach (var i in zip)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var zip2=numbers.Zip(numbers2,(n,n2)=>n+n2);
            foreach (var i in zip2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
