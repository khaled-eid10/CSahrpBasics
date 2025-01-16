using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Relationships.Assosiation
{
    public class Teacher
    {
        public string? Name { get; set; }

        public void Teach(Course course)
        {
            Console.WriteLine($"Teacher: {Name} , Course: {course.Title}");
        }
    }
}
