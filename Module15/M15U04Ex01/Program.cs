using System.Runtime.Intrinsics.Arm;

namespace M15U04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result1 = employees.Join(departments, emp => emp.DepartmentId, dep => dep.Id,
                (emp, dep) =>
                new
                {
                    Name = emp.Name,
                    Id = emp.Id,
                    Depart = dep.Name,
                    DepId = dep.Id
                });

            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Name} ({item.Id}) - отдел: {item.Depart} ({item.DepId})");
            }

            Console.WriteLine("\n\n");

            var result2 = from employee in employees
                          join dep in departments on employee.DepartmentId equals dep.Id
                          select new
                          {
                              Name= employee.Name,
                              Id = employee.Id,
                              Depart = dep.Name,
                              DepId = dep.Id
                          };
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Name} ({item.Id}) - отдел: {item.Depart} ({item.DepId})");
            }

            Console.WriteLine("\n\n");
            //GroupJoin
            var result3 = departments.GroupJoin(employees, dep=>dep.Id,emp=>emp.DepartmentId,
                (dep, emps) => new
                {
                    Name=dep.Name,
                    DepName=emps.Select(emp => emp.Name)
                });

            foreach(var item in result3)
            {
                Console.WriteLine(item.Name+": ");
                foreach(var emp in item.DepName)
                {
                    Console.WriteLine(emp);
                }
                Console.WriteLine();
            }

        }
    }
}
