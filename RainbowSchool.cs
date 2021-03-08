using System;
using System.Collections.Generic;
using System.Text;
namespace CSharpOopsProject
{
    class RainbowSchool
    {
        public static void Do()
        {

            List<Student> students = new List<Student>();
            List<Subject> subjects = new List<Subject>();
            Student s1 = new Student() { Name = "Yashasvi", ClassAndSection = "X B" };
            Student s2 = new Student() { Name = "Kumar", ClassAndSection = "XI B" };
            Student s3 = new Student() { Name = "Srivastava", ClassAndSection = "XII B" };
            students.Add(s1);students.Add(s2);students.Add(s3);
            Subject subj1 = new Subject() { Name = "Mrs Joolie", SubjectCode = " Phy-C001", ClassAndSection = "X B" };
            Subject subj2 = new Subject() { Name = "Mr Robot", SubjectCode = " Chem-C002", ClassAndSection = "XI B" };
            Subject subj3 = new Subject() { Name = "Mr Ronit", SubjectCode = " Maths-C003", ClassAndSection = "XII B" };
            subjects.Add(subj1);subjects.Add(subj2);subjects.Add(subj3);
            Console.WriteLine("Displaying the following lists:");
            Console.WriteLine("=======Students in a class======");
            foreach(Student s in students)
                Console.WriteLine(s.GetInfo());
            Console.WriteLine("=======Subjects Taught By Teacher======");
            foreach(Subject s in subjects)
                Console.WriteLine(s.GetInfo());
        }
    }
}
