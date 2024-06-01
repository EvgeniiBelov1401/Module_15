namespace M15U02Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var students = new List<Student>
                {
                   new Student {Name="Андрей", Age=random.Next(18,30) },
                   new Student {Name="Сергей", Age=random.Next(18,30) },
                   new Student {Name="Дмитрий", Age=random.Next(18,30) }
                };

                foreach (var student in students)
                {
                    Console.WriteLine(student.Name+" - "+student.Age);
                }
                Console.WriteLine($"\nСумма возрастов: {students.Sum(x=>x.Age)}");

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
