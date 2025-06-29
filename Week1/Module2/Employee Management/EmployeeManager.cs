using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class EmployeeManager
    {
        private Employee[] employees;
        private int count;

        public EmployeeManager(int capacity)
        {
            employees = new Employee[capacity];
            count = 0;
        }

        public void AddEmployee(Employee emp)
        {
            if (count < employees.Length)
            {
                employees[count++] = emp;
            }
            else
            {
                Console.WriteLine("Employee list is full.");
            }
        }

        public void TraverseEmployees()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        public Employee SearchEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                    return employees[i];
            }
            return null;
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    employees[--count] = null;
                    Console.WriteLine("Employee deleted.");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}
