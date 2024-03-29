using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Studentsystem
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
        public double Grade { get; set; }

        // Constructor with parameters
        public Studentsystem(string studentID, string firstName, string lastName, int age, string gender, string className, double grade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            ClassName = className;
            Grade = grade;
        }

        // Parameterless constructor
        public Studentsystem()
        {
            // Initialize properties if needed
        }
    }
}
