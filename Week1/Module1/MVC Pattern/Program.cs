using System;

namespace MVC_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student { 
                Name="Soham",
                Id=100,
                Grade="A"
  
                };

            StudentView View = new StudentView();

            StudentController controller=new StudentController(student,View);

            controller.UpdateView();

            Console.WriteLine("\nUpdating student info...\n");

            
            controller.SetStudentName("Siya");
            controller.SetStudentGrade("A+");

            
            controller.UpdateView();

        }


    }
}