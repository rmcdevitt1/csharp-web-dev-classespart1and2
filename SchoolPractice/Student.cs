using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string v1;
        private int v2;
        private int v3;
        private double v4;

        public Student(string v1, int v2, int v3, double v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }
    }
}
