using System.Collections.Generic;

namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string Position { get; set; }
        public List<string> Languages { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Id = 1001,
                    FirstName = "Ulugbek",
                    LastName = "Pulathodjayev",
                    Age = 25,
                    Salary = 2000,
                    Position = "Team Lead",
                    Languages = new List<string>() { "C#", "JavaScript", "Python" }
                },
                new Employee
                {
                    Id = 1002,
                    FirstName = "Antony",
                    LastName = "Volkonovski",
                    Age = 30,
                    Salary = 1800,
                    Position = "Middle",
                    Languages = new List<string>() { "C#", "Java", "SQL" }
                },
                new Employee
                {
                    Id = 1003,
                    FirstName = "Martin",
                    LastName = "Aston",
                    Age = 28,
                    Salary = 2500,
                    Position = "Senior",
                    Languages = new List<string>() { "C#", "Python", "Ruby" }
                },
                new Employee
                {
                    Id = 1004,
                    FirstName = "Lamborghini",
                    LastName = "Ferrari",
                    Age = 22,
                    Salary = 1500,
                    Position = "Junior",
                    Languages = new List<string>() { "C#", "JavaScript", "HTML" }
                },
                new Employee
                {
                    Id = 1005,
                    FirstName = "MW2",
                    LastName = "Ghost",
                    Age = 24,
                    Salary = 1200,
                    Position = "Intern",
                    Languages = new List<string>() { "C#", "Python", "PHP" }
                }
            };
            return employees;
        }
    }
}