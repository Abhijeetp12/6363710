using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    public class StudentView
    {
        public void DisplayStudentDetails(string name,int id, string grade) {

            Console.WriteLine("Student Informations");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Grade: {grade}");

        }

    }
}
