namespace M15U04Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letters = new string[] { "A", "B", "C", "D", "E" };
            var numbers = new int[] { 1, 2, 3 };

            var zip=letters.Zip(numbers,(l,n)=>l+n.ToString());

            foreach (var i in zip)
            {
                Console.WriteLine(i);
            }
        }
    }
}
