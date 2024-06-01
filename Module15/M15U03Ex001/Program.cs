namespace M15U03Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };

            //LINQ
            var carsByCountry = from car in cars
                                group car by car.CountryCode;
                                
            foreach(var item in carsByCountry )
            {
                Console.WriteLine(item.Key+": ");
                foreach(var car in item)
                {
                    Console.WriteLine(car.Manufacturer);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
            //Методы расширения
            var carsByCountry1 = cars.GroupBy(x => x.CountryCode);
            foreach(var carcountry in carsByCountry1)
            {
                Console.WriteLine(carcountry.Key+": ");
                foreach (var car in carcountry)
                {
                    Console.WriteLine(car.Manufacturer);
                }
                Console.WriteLine();
            }

        }
    }
}
