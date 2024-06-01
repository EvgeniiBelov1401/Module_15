namespace M15U02Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Random random = new Random();
                var studentsJournal = new List<Students>
            {
                new Students("Алексей",random.Next(18,30)),
                new Students("Иван",random.Next(18,30)),
                new Students("Ирина",random.Next(18,30)),
                new Students("Павел",random.Next(18,30)),
                new Students("Юлия",random.Next(18,30)),
                new Students("Петр",random.Next(18,30)),
                new Students("Анна",random.Next(18,30)),
                new Students("Мария",random.Next(18,30)),
                new Students("Андрей",random.Next(18,30)),
                new Students("Семен",random.Next(18,30)),
            };
                foreach (var student in studentsJournal)
                {
                    Console.WriteLine(student.Name+" - "+student.Age+" лет.");
                }

                Console.WriteLine($"\nМладше 25 лет: {studentsJournal.Count(x=>x.Age<25)} студентов.");

                Console.WriteLine();
                Console.ReadLine(); 
                Console.Clear();
            }
        }
    }
}
