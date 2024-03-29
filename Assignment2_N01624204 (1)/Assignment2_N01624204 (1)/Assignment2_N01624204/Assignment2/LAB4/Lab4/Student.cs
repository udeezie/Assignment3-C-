using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student
    {
        string name { get; set; }
        public List<Test> Tests { get; set; }

        public Student(string name)
        {
            this.name = name;
            Tests = new List<Test>();
        }

        public Student(string name, List<Test> tests)
        {
            this.name = name;
            Tests = tests;
        }

        public override string ToString()
        {
            return name + " | ";
        }

    }
}
