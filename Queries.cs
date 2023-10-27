using LINQ.Second;

namespace LINQ
{
    internal class Queries
    {
        public static void Run()
        {
            //List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,23,42,34};

            //IEnumerable<int> query = numbers.Where (x => x%2 == 0).ToList();

            ////method syntax 
            //List<int> query1 = (from  x in numbers where x % 2 == 0 select x).ToList();

            ////mixed syntax
            //List<int> query2 = (from x in numbers select x).Where(x => x % 2 == 0).ToList();

            ////Query syntax

            //var QS = from number in numbers
            //         where number % 2 == 0
            //         select number;


            //foreach (var number in query2)
            //{
            //    Console.WriteLine(number);
            //}


            //var employeeSalary = from salary in Employee.GetEmployees()
            //                     select (salary.FirstName, Salary: salary.Salary, salary.Position);

            //employeeSalary = employeeSalary.OrderByDescending(employee => employee.Salary);

            //var highestSalary = employeeSalary.First();
            //var lowestSalary = employeeSalary.Last();

            //Console.WriteLine("Сотрудник с наивысшей зарплатой:");
            //Console.WriteLine(highestSalary.FirstName + ": " + highestSalary.Salary);

            //Console.WriteLine("Сотрудник с наименьшей зарплатой:");
            //Console.WriteLine(lowestSalary.FirstName + ": " + lowestSalary.Salary);

            //Console.WriteLine("\n \n \n");
            //foreach (var employee in employeeSalary)
            //{
            //    float countFirst = employee.Salary * 12;
            //    Console.WriteLine(employee.FirstName + " " + countFirst);
            //}


            //var employees = Employee.GetEmployees();

            //var employeeLanguages = employees.SelectMany(employee =>
            //                            new[] { $"{employee.FirstName}: {string.Join(", ", employee.Languages)}" });

            //foreach (var info in employeeLanguages)
            //{
            //    Console.WriteLine(info);
            //}



        }
    }
}

