
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Employee_Management;

class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager(10);

        manager.AddEmployee(new Employee ( 1, "Abhijeet", "IT", 50000 ));
        manager.AddEmployee(new Employee ( 2, "Aditya", "Developer",  75000 ));

        Console.WriteLine("All Employees:");
        manager.TraverseEmployees();

        Console.WriteLine("\nSearching for Employee with ID 2:");
        var emp = manager.SearchEmployee(2);
        Console.WriteLine(emp != null ? emp.ToString() : "Not found.");

        Console.WriteLine("\nDeleting Employee with ID 1:");
        manager.DeleteEmployee(1);
        manager.TraverseEmployees();
    }
}