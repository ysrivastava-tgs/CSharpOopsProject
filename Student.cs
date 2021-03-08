using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOopsProject
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Class And Section: {ClassAndSection}";
        }
    }
}
