using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public int CourseNo { get; set; }
        public List<Student> Student = new List<Student>();
        public Teacher CourseTeacher {get; set;}

        public Course(int courseNo, List<Student> student, Teacher courseTeacher)
        {
            CourseNo = courseNo;
            Student = student;
            this.CourseTeacher = courseTeacher;
        }

    }
}
