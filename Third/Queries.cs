using LINQ.Second;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Third
{
    public class Queries
    {

        var allStudents = Student.GetAllStudents();
        var allTeachers = Teacher.GetAllTeachers();


        var result = allTeachers.GroupJoin(allStudents,
                                    teacher => teacher.StudyType,
                                    student => student.StudyType,
                                    (teacher, students) => new
                                    {
                                        TeacherName = teacher.FirstName,
                                        Students = students,
                                        StudyType = teacher.StudyType
                                    });

            foreach (var teacher in result)
            {
                Console.WriteLine($"{teacher.TeacherName} Talim shakli: {teacher.StudyType} =>");
                foreach (var student in teacher.Students)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} ({student.StudyType})");
                }
    Console.WriteLine();
            }
    }
}
