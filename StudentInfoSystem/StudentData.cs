using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        static public List<Student> TestStudents { get; } = new List<Student>()
        {
            new Student("Ivan", "Ivanov", "Ivanov", "FKST", "KSI", "bachelor", "ОК", "121219***", 6, 1, 31)
        };
    }
}
