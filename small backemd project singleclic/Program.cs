using System;
using System.Collections.Generic;
using System.Linq;

namespace small_backend_project_singleclic
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                var devDept = new Department { Id = 1, Name = "Development" };
                var designDept = new Department { Id = 2, Name = "Design" };

                var employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Rohym", Department = devDept },
                    new Employee { Id = 2, Name = "Sama", Department = designDept },
                    new Employee { Id = 3, Name = "Ahmed", Department = devDept }
                };

                var searchResult = employees.FirstOrDefault(e => e.Id == 1);
                Console.WriteLine($"Search Result: {searchResult?.Name}");

                var devs = employees.Where(e => e.Department.Name == "Development").ToList();
                Console.WriteLine($"\nDevelopers count: {devs.Count}");

                var sortedEmployees = employees.OrderBy(e => e.Name).ToList();
                Console.WriteLine("\nSorted Employees:");
                foreach (var emp in sortedEmployees)
                {
                    Console.WriteLine($"- {emp.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}