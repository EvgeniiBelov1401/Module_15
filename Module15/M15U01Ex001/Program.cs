namespace M15U01Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drinks = {"Вино","Кока-Кола","Пиво","Лимонад","Сок", "Сок" };
            string[] alcohol = { "Вино", "Пиво" };

            var drinksForKids=drinks.Except(alcohol);

            foreach (var item in drinksForKids)
            {
                Console.WriteLine(item);
            }
        }
    }
}
