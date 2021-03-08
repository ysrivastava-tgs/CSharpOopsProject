using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOopsProject
{
    public class Subject:Teacher
    {
        public string SubjectCode { get; set; }
        public Teacher Teacher;
        public override string GetInfo()
        {
            {
                return $"Name: {Name}, Class And Section: {ClassAndSection}, Subject Code: {SubjectCode}";
            }
        }
    }
}
