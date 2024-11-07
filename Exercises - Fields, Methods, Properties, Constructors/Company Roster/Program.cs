namespace Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];
                string email = "n/a";
                int age = -1;

                if (tokens.Length == 5)
                {
                    if (tokens[4].Contains("@"))
                        email = tokens[4];
                    else
                        age = int.Parse(tokens[4]);
                }
                else if (tokens.Length == 6)
                {
                    email = tokens[4];
                    age = int.Parse(tokens[5]);
                }

                employees.Add(new Employee(name, salary, position, department, email, age));
            }

            var departmentGroups = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary),
                    Employees = g.OrderByDescending(e => e.Salary).ToList()
                })
                .OrderByDescending(g => g.AverageSalary)
                .FirstOrDefault();

            if (departmentGroups != null)
            {
                Console.WriteLine($"Highest Average Salary: {departmentGroups.Department}");
                foreach (var emp in departmentGroups.Employees)
                {
                    Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
                }
            }
        }
    }
}
