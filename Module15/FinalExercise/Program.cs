using FinalExercise.Modules;

namespace FinalExercise
{
    internal class Program
    {
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(c => c.Students).ToArray();
        }
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            while (true)
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    var oneClass=classes.ToList()[i].Students;                    
                    Console.WriteLine($"Класс {i + 1}: "+string.Join(" ",oneClass));
                }

            
                Console.WriteLine("\n\nСобрать всех учеников в одном классе (нажмите ENTER)");
                Console.ReadLine();

                var allStudents = GetAllStudents(classes);
                Console.WriteLine("Актовый зал: " + string.Join(" ", allStudents));

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
