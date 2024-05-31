namespace M15U01Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

            var microBuses=cars.Intersect(buses);

            foreach(string s in microBuses)
            {
                Console.WriteLine(s);
            }
        }
    }
}
