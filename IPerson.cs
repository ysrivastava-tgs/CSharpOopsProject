using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOopsProject
{
    interface IPerson
    {
        string Name { get; set; }
        string ClassAndSection { get; set; }
        public string GetInfo();
    }
}
