namespace LINQ.Second
{
    public class QueriesForStudent
    {
        public static void Run()
        {
            //Method Syntax

            //List<Student> students = Student.GetAllStudents().ToList();
            //students.OrderBy(x => x.FirstName)
            //    .ThenByDescending(x => x.Course)
            //    .ThenBy(x => x.Contract)
            //    .ThenByDescending(x => x.Age);

            //var counts = Student.GetAllStudents().Count();
            //var sums  = students.Sum(x => x.Contract);
            //var a = students.Average(x => x.Contract);
            //var age = students.Average(x => x.Age);

            //Console.WriteLine(sums / counts);

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Name: {student.FirstName}, Course: {student.Course}, Contract: {student.Contract}, Age: {student.Age}");
            //}

            List<Student> students = Student.GetAllStudents().ToList();

            bool result = students.Any(s => s.Sirtqi == "Sirtqi");
            Console.WriteLine(result);

            List<Student> filteredStudents = students
            .Where(s => s.Sirtqi == "Sirtqi")
            .Select(s => s)
            .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.Course);
            }




            //Query Syntax

            //List<Student> students = (from student in Student.GetAllStudents()
            //                          orderby student.FirstName ascending,
            //                                  student.Course descending,
            //                                  student.Contract ascending,
            //                                  student.Age descending
            //                          select student).ToList();

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Name: {student.FirstName}, Course: {student.Course}, Contract: {student.Contract}, Age: {student.Age}");
            //}


        }
    }
}
