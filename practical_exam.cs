using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create departments
            Department hrDepartment = new Department { Id = 1, Name = "HR" };
            Department itDepartment = new Department { Id = 2, Name = "IT" };

            // Create roles
            Role internRole = new Role { Id = 1, Name = "Intern" };
            Role backendRole = new Role { Id = 2, Name = "Backend" };

            // Create employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Ram", Salary = 60000, Department = hrDepartment, Role = internRole },
                new Employee { Id = 2, Name = "Hari", Salary = 70000, Department = hrDepartment, Role = internRole },
                new Employee { Id = 3, Name = "Sita", Salary = 50000, Department = itDepartment, Role = backendRole },
                new Employee { Id = 4, Name = "Gita", Salary = 80000, Department = itDepartment, Role = backendRole },

            };

            // Use LINQ 
            var queryResult = from emp in employees
                              where emp.Role == backendRole
                                    && emp.Department == itDepartment
                                    && emp.Salary > 60000
                              select emp;

            // Display  results
            Console.WriteLine("Employees with salary greater than 60000:");
            foreach (var employee in queryResult)
            {
                Console.WriteLine($"Name: {employee.Name}, Department: {employee.Department.Name}, Role: {employee.Role.Name}, Salary: {employee.Salary}");
            }

            Console.ReadLine();
        }
    }

    //Employee class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        public Role Role { get; set; }
    }

    // Department class
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //  Role class
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
