namespace M15U05Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
               new Student {Name="Андрей", Age=23 },
               new Student {Name="Сергей", Age=27 },
               new Student {Name="Дмитрий", Age=29 }
            };

            var youngStudents = students.Where(x => x.Age < 25);
            Console.WriteLine(youngStudents.Count());

            students.Add(new Student { Name = "Анна", Age = 21 });

            foreach (var student in youngStudents)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine(youngStudents.Count());
        }
    }
}
