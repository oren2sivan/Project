using System;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Student new_student= new Student("John", 4344, 20);
            new_student.SetAge(21);
            new_student.SetStudentName("Oren");
            new_student.SetStudentID(1234);
            new_student.DisplayInformation();
            CollegeStudent std=new CollegeStudent("John", 4344, 20,"Computer Science",90);
            std.DisplayInformation();
        }
    }
}

