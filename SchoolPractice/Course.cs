using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        private int CourseNo { get; set; }
        private List<Student> Student = new List<Student>();
        private Teacher cTeacher {get; set;}

        public Course(int courseNo, List<Student> student, Teacher cTeacher)
        {
            CourseNo = courseNo;
            Student = student;
            this.cTeacher = cTeacher;
        }

    }
}
