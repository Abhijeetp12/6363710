﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeId, string name, string position, double salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}
