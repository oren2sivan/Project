using System;

namespace ConsoleApp1
{
    
     class Student
    {
        string studentName;
        int studentID;
        int age;

        public Student(string studentName, int studentID, int age)

        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.age = age;
        }

        public virtual void  DisplayInformation()
        {
            Console.WriteLine("StudentName:"+this.studentName);
            Console.WriteLine("StudentID:"+this.studentID);
            Console.WriteLine("Age:"+this.age);
        }

        public Tuple<string, int, int> GetStudentInfo()
        {
            return Tuple.Create(this.studentName, this.studentID, this.age);
        }

        public string Getstudentname()
        {
            return this.studentName;
        }
        public int GetstudentID()
        {
            return this.studentID;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetStudentName(string studentName)
        {
            this.studentName = studentName;
        }
        public void SetStudentID(int studentID)
        {
            this.studentID = studentID;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }   

    }
    
     interface IPerson
    {
        void DisplayInformation()
        {}
        
    }
   
    class CollegeStudent: Student
    {
        protected string subject;
        protected int avg;

        public CollegeStudent(string studentName, int studentID, int age, string subject, int avg) : base(studentName, studentID, age)
        {
            this.subject = subject;
            this.avg = avg;
        }

        public override void  DisplayInformation()
        {
                Console.WriteLine("Subject: " + this.subject);
                Console.WriteLine("Average: " + this.avg);
        }
        
        
    }

    
}


