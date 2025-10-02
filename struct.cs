using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student st;
            st.id = 101;
            st.name = "Kamali";
            st.age = 22;
            st.course = "Dotnet";
            st.display();

        }
        struct student //group small number of related data objects  
        {
            public int id;
            public string name;
            public int age;
            public string course;

            public void display()
            {
                Console.WriteLine("The Role Number is" + id);
                Console.WriteLine("student name" + name);
                Console.WriteLine("Student age" + age);
                Console.WriteLine("Selected course" + course);
            }
        }
    }
}
