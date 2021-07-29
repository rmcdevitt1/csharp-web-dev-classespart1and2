using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student("Raine", 42069, 1, 4.0);
            Student s2 = new Student("Jenny", 8675309, 2, 3.6);
            Student s3 = new Student("Jean ValJean", 24601, 3, 2.3);

            List<Student> studentsList = new List<Student>();
            studentsList.Add(myStudent);
            studentsList.Add(s2);
            studentsList.Add(s3);

            Teacher t1 = new Teacher("John", "Wickersham", "Bigfoot Studies", 50);

            Course bigfootStudies = new Course(101, studentsList, t1);

        }
    }
}
