﻿using System;
namespace SchoolPractice
{
    public class Teacher
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Subject { get; set; }
        private int YearsTeaching { get; set; }


        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }

    }
}
