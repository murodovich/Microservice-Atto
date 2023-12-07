﻿using School.Domain.Entities.StudentCourses;
using School.Domain.Enums;
namespace School.Domain.Entities.Students
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        
        public Role Role { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}