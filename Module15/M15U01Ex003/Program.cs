namespace M15U01Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

            var garage = cars.Union(buses);

            foreach ( var car in garage )
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            
            var allVehicle=cars.Concat(buses);

            foreach( var car in allVehicle)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            string[] cars2 = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
            var uniqueCars=cars2.Distinct();
            foreach ( var car in uniqueCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
