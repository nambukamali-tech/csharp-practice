using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_record_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { name = "Nambu", age = 22, marks = 99, result = "pass" });
            students.Add(new Student { name = "Kamali", age = 23, marks = 100, result = "pass" });
            foreach(Student s in students)
            {
                s.details();
            }
            Console.ReadKey();
        }
        class Student
        {
            public string name;
            public int age;
            public double marks;
            public string result;
            public void details()
            {
                Console.WriteLine("Student Details");
                Console.WriteLine($"Name:{name},Age:{age},Marks:{marks},Result:{result}");
               
               

            }
        }
    }
}
